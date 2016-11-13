using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;
using System.IO;
using System.Xml.Serialization;

namespace POS.Admin.Business
{
    public class InventariosBL
    {
        InventariosDL inventariosDL = new InventariosDL();

        public InventariosBL()
        {
            inventariosDL = new InventariosDL();
        }

        public DataTable getInventarios(string proveedorID, string descripcion)
        {
            DataTable table = inventariosDL.getInventarios(proveedorID, descripcion);
            return table;
        }

        public String genera_reporte(DataTable tbInventario)
        {
            string fic = "Inventario_" + DateTime.Now.ToFileTime().ToString() + ".xls";
            if (File.Exists(fic))
                File.Delete(fic);
            StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

            try
            {
                if (tbInventario.Rows.Count > 0)
                {
                    //CABECERA
                    sw.Write("C�DIGO EAN" + '\t');
                    sw.Write("DESCRIPCI�N" + '\t');
                    sw.Write("PRECIO VENTA" + '\t');
                    sw.Write("PRECIO COSTO" + '\t');
                    sw.Write("EXISTENCIA" + '\t');
                    sw.Write("�LTIMA MODIFICACI�N" + '\n');

                    sw.Write('\n');

                    foreach (DataRow Row in tbInventario.Rows)
                    {
                        sw.Write(Row["codigo_ean"].ToString() + '\t');
                        sw.Write(Row["descripcion"].ToString() + '\t');
                        sw.Write(Row["p_venta"].ToString() + '\t');
                        sw.Write(Row["p_costo"].ToString() + '\t');
                        sw.Write(Row["existencia"].ToString() + '\t');
                        sw.Write(Row["ultima_modificacion"].ToString() + '\n');
                    }
                    sw.Write('\n');

                    sw.Close();

                    System.Diagnostics.Process.Start(fic);
                    return "Exportaci�n Exitosa";
                }
                else
                    return "Es necesario cargar informaci�n";
            }
            catch (Exception xm)
            {
                return "Error al Exportar";
            }
            finally
            {

            }
        }
    }
}
