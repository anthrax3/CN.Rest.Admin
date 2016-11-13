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
    public class OrdenesBL
    {
        private OrdenesDL ordenesDL = new OrdenesDL();

        public OrdenesBL()
        {
            ordenesDL = new OrdenesDL();
        }

        public DataTable getOrdenes(string factura, string orden, string empresaID)
        {
            DataTable table = ordenesDL.getOrdenes(factura, orden, empresaID);
            return table;
        }

        public string setOrdenes(ref Ordenes ordenes, ref Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = ordenesDL.existe_orden(ordenes.factura, ordenes.noOrden, empresaID);
                    if (value > 0)
                        response = "Ya existe la Orden con ID: " + value.ToString();
                    else
                    {
                        if (ordenesDL.genera_orden(ordenes, "ins_orden") > 0)
                        {
                            ordenes.id = ordenesDL.getOrdenID(ordenes.factura, ordenes.noOrden, empresaID);
                            response = "Nueva Orden agregada";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar la Orden";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (ordenesDL.genera_orden(ordenes, "upd_orden") > 0)
                        response = "Orden modificada";
                    else
                        response = "Error, no se pudo modificar la Orden";
                    break;
                default:
                    break;
            }
            return response;
        }

        public DataTable getDetalle(string ordenID)
        {
            DataTable table = ordenesDL.getDetalle(ordenID);
            return table;
        }

        public DataTable getArticuloDetalle(string ean, string empresaID)
        {
            DataTable table = ordenesDL.getArticuloDetalle(ean, empresaID);
            return table;
        }

        public string setDetalle(ordenDetalle ordendetalle, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = ordenesDL.existe_detalle(ordendetalle.ean, ordendetalle.ordenID);
                    if (value > 0)
                        response = "Ya existe el Artículo con ID: " + value.ToString();
                    else
                    {
                        if (ordenesDL.inserta_detalle(ordendetalle, "ins_orden_detalle") > 0)
                            response = "Nueva Artículo agregado";
                        else
                            response = "Error, no se pudo insertar el Artículo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (ordenesDL.actualiza_detalle(ordendetalle, "upd_orden_detalle") > 0)
                        response = "Artículo modificado";
                    else
                        response = "Error, no se pudo modificar el Artículo";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaOrden(Ordenes ordenes)
        {
            if (ordenesDL.eliminaOrden(ordenes) > 0)
                return "Orden con ID: " + ordenes.id + " borrada";
            else
                return "Orden con ID: " + ordenes.id + " no pudo ser borrada";
        }

        public string eliminaDetalle(ordenDetalle ordendetalle)
        {
            if (ordenesDL.eliminaDetalle(ordendetalle) > 0)
                return "Artículo con ID: " + ordendetalle.id + " borrado";
            else
                return "Artículo con ID: " + ordendetalle.id + " no pudo ser borrado";
        }

        public void calculaTotal(DataTable tabla, ref decimal _subtotal,ref decimal _iva, ref decimal _total)
        {
            foreach (DataRow Row in tabla.Rows)
            {
                _subtotal += Convert.ToDecimal(Row["subtotal"]);
                _iva += Convert.ToDecimal(Row["importe_iva"]);
                _total += Convert.ToDecimal(Row["total"]);
            }
        }

        public void calculaPartida(decimal costo, decimal cantidad, ref decimal _subtotal, ref decimal _iva, ref decimal _total)
        {
            _subtotal = (cantidad * costo);
            _iva = (_subtotal * (_iva / 100));
            _total =  (_subtotal + _iva);
        }

        public String genera_reporte(Ordenes ordenes, DataTable ordendetalle)
        {
            string fic = "Orden_" + ordenes.id.ToString() + ".xls";
            if (File.Exists(fic))
                File.Delete(fic);
            StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

            try
            {
                if (ordenes.id.Length > 0)
                {
                    //CABECERA
                    sw.Write("ID" + '\t');
                    sw.Write("NUMERO DE ORDEN" + '\t');
                    sw.Write("FACTURA" + '\t');
                    sw.Write("PROVEEDOR" + '\t');
                    sw.Write("SUCURSAL" + '\t');
                    sw.Write("ESTATUS" + '\n');

                    sw.Write(ordenes.id + '\t');
                    sw.Write(ordenes.noOrden + '\t');
                    sw.Write(ordenes.factura + '\t');
                    sw.Write(ordenes.proveedorID + '\t');
                    sw.Write(ordenes.sucursalID + '\t');
                    sw.Write(ordenes.estatus + '\n');
                    sw.Write('\n');

                    //DETALLE
                    sw.Write("DETALLE ID" + '\t');
                    sw.Write("CÓDIGO EAN" + '\t');
                    sw.Write("DESCRIPCIÓN" + '\t');
                    sw.Write("CANTIDAD" + '\t');
                    sw.Write("PRECIO COSTO" + '\t');
                    sw.Write("PRECIO VENTA" + '\t');
                    sw.Write("SUBTOTAL" + '\t');
                    sw.Write("IVA" + '\t');
                    sw.Write("TOTAL" + '\n');

                    foreach (DataRow Row in ordendetalle.Rows)
                    {
                        sw.Write(Row["detalleID"].ToString() + '\t');
                        sw.Write(Row["codigo_ean"].ToString() + '\t');
                        sw.Write(Row["descripcion"].ToString() + '\t');
                        sw.Write(Row["cantidad"].ToString() + '\t');
                        sw.Write(Row["p_costo"].ToString() + '\t');
                        sw.Write(Row["p_venta"].ToString() + '\t');
                        sw.Write(Row["subtotal"].ToString() + '\t');
                        sw.Write(Row["iva"].ToString() + '\t');
                        sw.Write(Row["total"].ToString() + '\n');
                    }
                    sw.Write('\n');

                    //TOTALES
                    sw.Write("SUBTOTAL" + '\t');
                    sw.Write("TOTAL IVA" + '\t');
                    sw.Write("GRAN TOTAL" + '\n');

                    sw.Write(ordenes.subtotal + '\t');
                    sw.Write(ordenes.total_iva + '\t');
                    sw.Write(ordenes.grantotal + '\n');

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

        public String exporta_reporte(Ordenes ordenes, DataTable ordendetalle)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Ordenes));
            System.IO.StreamWriter sw = null;
            ordenDetalle OrdenDetalle = new ordenDetalle();

            try
            {
                if (ordenes.id.Length > 0)
                {
                    ordenes.OrdenDetalle.Clear();
                    foreach (DataRow row in ordendetalle.Rows)
                    {
                        OrdenDetalle = new ordenDetalle();
                        OrdenDetalle.ean = row["codigo_ean"].ToString();
                        OrdenDetalle.descripcion = row["descripcion"].ToString();
                        OrdenDetalle.cantidad = row["cantidad"].ToString();
                        OrdenDetalle.venta = row["p_venta"].ToString();
                        OrdenDetalle.costo = row["p_costo"].ToString();
                        OrdenDetalle.subtotal = row["subtotal"].ToString();
                        OrdenDetalle.iva = row["iva"].ToString();
                        OrdenDetalle.total = row["total"].ToString();
                        ordenes.OrdenDetalle.Add(OrdenDetalle);
                    }

                    if (File.Exists("ordenPOS.xml"))
                        File.Delete("ordenPOS.xml");
                    sw = new System.IO.StreamWriter("ordenPOS.xml");
                    serializer.Serialize(sw, ordenes);
                    ordenes.OrdenDetalle.Clear();

                    return "Generación Exitosa";
                }
                else
                    return "Es necesario cargar información";
            }
            catch (Exception xm)
            {
                sw.Close();
                return "Error al Exportar";
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
