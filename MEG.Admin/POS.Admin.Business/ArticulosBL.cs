using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;
using System.IO;
using utils = POS.Utilities.Utils;

namespace POS.Admin.Business
{
    public class ArticulosBL
    {
        private ArticulosDL articulosDL;

        public ArticulosBL()
        {
            articulosDL = new ArticulosDL();
        }

        public DataTable getArticulos(string descripcion, string estatus, string empresaID)
        {
            DataTable table = articulosDL.getArticulos(descripcion, estatus, empresaID);
            return table;
        }

        public DataTable getArticulosSubCat(string subCategoriaID)
        {
            DataTable table = articulosDL.getArticulosSubCat(subCategoriaID);
            return table;
        }

        public DataTable getArticulos(string busqueda, int tipo, string empresaID)
        {
            DataTable table = articulosDL.getArticulos(busqueda, tipo, empresaID);
            return table;
        }

        public DataTable getArticulosSinProveedor(string busqueda, int tipo, int proveedorID, string empresaID)
        {
            DataTable table = articulosDL.getArticulosSinProveedor(busqueda, tipo, proveedorID, empresaID);
            return table;
        }

        public int setNuevoCodigo(string eanActual, string eanNuevo, string empresaID)
        {
            return articulosDL.setNuevoCodigo(eanActual, eanNuevo, empresaID);
        }

        public List<System.String> getEstatus()
        {
            List<String> estatus = new List<String>();

            foreach (DataRow Row in articulosDL.getEstatus().Rows)
                estatus.Add(Row["descripcion"].ToString());

            return estatus;
        }

        public string setArticulos(Articulos articulos, Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = articulosDL.existe_articulo(articulos.ean, empresaID);
                    if (value > 0)
                        response = "Ya existe el articulo con ID: " + value.ToString();
                    else
                    {
                        if (articulosDL.genera_articulo(articulos, "ins_articulos", empresaID) > 0)
                            response = "Nuevo artículo agregado";
                        else
                            response = "Error, no se pudo insertar el Artículo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (articulosDL.genera_articulo(articulos, "upd_articulos", empresaID) > 0)
                        response = "Artículo modificado";
                    else
                        response = "Error, no se pudo modificar el Artículo";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaArticulo(Articulos articulos, string empresaID)
        {
            if (articulosDL.eliminaArticulo(articulos, empresaID) > 0)
                return "Artículo con ID: " + articulos.id + " borrado";
            else
                return "Artículo con ID: " + articulos.id + " no pudo ser borrado";
        }

        public String genera_reporte(DataTable tbArticulos)
        {
            string fic = "Articulos_" + DateTime.Now.ToFileTime().ToString() + ".xls";
            if (File.Exists(fic))
                File.Delete(fic);
            StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

            try
            {
                if (tbArticulos.Rows.Count > 0)
                {
                    //CABECERA
                    sw.Write("ARTICULO ID, " + '\t');
                    sw.Write("CODIGO EAN" + '\t');
                    sw.Write("DESCRIPCION" + '\t');
                    sw.Write("P. VENTA" + '\t');
                    sw.Write("P. COSTO" + '\t');
                    sw.Write("IMPUESTO" + '\t');
                    sw.Write("ESTATUS" + '\t');
                    sw.Write("ULTIMA MODIFICACION" + '\n');

                    sw.Write('\n');

                    foreach (DataRow Row in tbArticulos.Rows)
                    {
                        sw.Write(Row["articuloID"].ToString() + '\t');
                        sw.Write(Row["codigo_ean"].ToString() + '\t');
                        sw.Write(Row["descripcion"].ToString() + '\t');
                        sw.Write(Row["p_venta"].ToString() + '\t');
                        sw.Write(Row["p_costo"].ToString() + '\t');
                        sw.Write(Row["impuesto"].ToString() + '\t');
                        sw.Write(Row["estatus"].ToString() + '\t');
                        sw.Write(Row["ultima_modificacion"].ToString() + '\n');
                    }
                    sw.Write('\n');

                    sw.Close();

                    System.Diagnostics.Process.Start(fic);
                    return "Exportación Exitosa";
                }
                else
                    return "Es necesario cargar información";
            }
            catch (Exception xm)
            {
                return "Error al Exportar";
            }
            finally
            {

            }
        }

        public String genera_archivo_terminal(DataTable tbArticulos)
        {
            string fic = utils.getPathTerminal().Trim() + "articulos.xml";

            if (Directory.Exists(utils.getPathTerminal().Trim()))
            {
                if (File.Exists(fic))
                    File.Delete(fic);

                StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

                try
                {
                    if (tbArticulos.Rows.Count > 0)
                    {
                        sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                        sw.WriteLine("<articulos>");
                        foreach (DataRow Row in tbArticulos.Rows)
                        {
                            sw.WriteLine("<articulo>");
                            sw.WriteLine("<codigo>" + putAmp(Row["codigo_ean"].ToString().Trim()) + "</codigo>");
                            sw.WriteLine("<descripcion>" + putAmp(Row["descripcion"].ToString().Trim()) + "</descripcion>");
                            sw.WriteLine("<precio>" + putAmp(Row["p_costo"].ToString().Trim().ToUpper()) + "</precio>");
                            sw.WriteLine("</articulo>");
                        }
                        sw.WriteLine("</articulos>");

                        sw.Close();

                        return "Exportación Exitosa";
                    }
                    else
                        return "Es necesario cargar información";
                }
                catch (Exception xm)
                {
                    return "Error al Exportar";
                }
                finally
                {

                }
            }
            else
                return "Error: No se encuentra el directorio del dispositivo móvil";
        }

        public string putAmp(string attribute)
        {
            if (attribute != null || attribute != "")
            {
                attribute = attribute.Replace("&", "");
                attribute = attribute.Replace(">", "");
                attribute = attribute.Replace("<", "");
                attribute = attribute.Replace("\"", "");
                attribute = attribute.Replace("\'", "");
                attribute = attribute.Replace("'", "");
                attribute = attribute.Replace("´", "");
                attribute = attribute.Replace("|", "");
                attribute = attribute.Replace("Ñ", "N");
                attribute = attribute.Replace("Á", "A");
                attribute = attribute.Replace("É", "E");
                attribute = attribute.Replace("Í", "I");
                attribute = attribute.Replace("Ó", "O");
                attribute = attribute.Replace("Ú", "U");
            }
            return attribute;
        }

        public int setImagenCodigo(List<ArticulosImagen> listaArtCodigo, string empresaID)
        {
            return articulosDL.setImagenCodigo(listaArtCodigo, empresaID);
        }

        public DataTable getArticulosProveedor(int proveedorID, string empresaID)
        {
            return articulosDL.getArticulosProveedor(proveedorID, empresaID);
        }

        public int delArticuloProv(string ean, int proveedorID, string empresaID)
        {
            return articulosDL.delArticuloProv(ean, proveedorID, empresaID);
        }

        public int ins_articulo_proveedor(List<ArticulosProveedor> listaArtProveedor, string empresaID)
        {
            return articulosDL.ins_articulo_proveedor(listaArtProveedor, empresaID);
        }

        public string insertImagenArticulo(Articulos articulos, string nombre, MemoryStream imagen, string mimeType, bool principal)
        {
            return articulosDL.ins_ImagenArticulo(articulos, nombre, imagen, mimeType, principal);
        }

        public DataTable getImagenArticulos(string articuloID)
        {
            return articulosDL.getImagenArticulos(articuloID);
        }

        public string eliminaImagenArticulo(string aImagenID, string nombre)
        {
            return articulosDL.eliminaImagenArticulo(aImagenID, nombre);
        }

    }
}
