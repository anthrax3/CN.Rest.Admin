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
    public class PedidosProveedorBL
    {
        private PedidosProveedorDL pedidosProveedorDL = new PedidosProveedorDL();

        public PedidosProveedorBL()
        {
            pedidosProveedorDL = new PedidosProveedorDL();
        }

        public DataTable getPedidos(string referencia, string empresaID)
        {
            DataTable table = pedidosProveedorDL.getPedidos(referencia, empresaID);
            return table;
        }

        public string setPedidos(ref PedidosProveedor pedidosProveedor, ref Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = pedidosProveedorDL.existe_pedido(pedidosProveedor.referencia, empresaID);
                    if (value > 0)
                        response = "Ya existe el Pedido con ID: " + value.ToString();
                    else
                    {
                        if (pedidosProveedorDL.genera_pedido_proveedor(pedidosProveedor, "ins_pedido_proveedor") > 0)
                        {
                            pedidosProveedor.id = pedidosProveedorDL.getpedidoID(pedidosProveedor.referencia, empresaID);
                            response = "Nuevo Pedido agregado";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar el Pedido";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (pedidosProveedorDL.genera_pedido_proveedor(pedidosProveedor, "upd_pedido_proveedor") > 0)
                        response = "Pedido modificado";
                    else
                        response = "Error, no se pudo modificar el Pedido";
                    break;
                default:
                    break;
            }
            return response;
        }

        public DataTable getDetalle(string pedidoID)
        {
            DataTable table = pedidosProveedorDL.getDetalle(pedidoID);
            return table;
        }

        public DataTable getArticuloDetalle(string ean, string empresaID)
        {
            DataTable table = pedidosProveedorDL.getArticuloDetalle(ean, empresaID);
            return table;
        }

        public string setDetalle(PedidoProveedorDetalle pedidoProveedorDetalle, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = pedidosProveedorDL.existe_detalle(pedidoProveedorDetalle.ean, pedidoProveedorDetalle.pedidoID);
                    if (value > 0)
                        response = "Ya existe el Artículo con ID: " + value.ToString();
                    else
                    {
                        if (pedidosProveedorDL.inserta_detalle(pedidoProveedorDetalle, "ins_pedido_proveedor_detalle") > 0)
                            response = "Nueva Artículo agregado";
                        else
                            response = "Error, no se pudo insertar el Artículo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (pedidosProveedorDL.actualiza_detalle(pedidoProveedorDetalle, "upd_pedido_proveedor_detalle") > 0)
                        response = "Artículo modificado";
                    else
                        response = "Error, no se pudo modificar el Artículo";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaPedido(PedidosProveedor pedidosProveedor)
        {
            if (pedidosProveedorDL.eliminaPedidoProveedor(pedidosProveedor) > 0)
                return "Pedido con ID: " + pedidosProveedor.id + " borrado";
            else
                return "Pedido con ID: " + pedidosProveedor.id + " no pudo ser borrado";
        }

        public string eliminaDetalle(PedidoProveedorDetalle pedidoProveedorDetalle)
        {
            if (pedidosProveedorDL.eliminaDetalle(pedidoProveedorDetalle) > 0)
                return "Artículo con ID: " + pedidoProveedorDetalle.id + " borrado";
            else
                return "Artículo con ID: " + pedidoProveedorDetalle.id + " no pudo ser borrado";
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

        public String genera_reporte(PedidosProveedor pedidosProveedor, DataTable ordendetalle)
        {
            string fic = "Orden_" + pedidosProveedor.id.ToString() + ".xls";
            if (File.Exists(fic))
                File.Delete(fic);
            StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

            try
            {
                if (pedidosProveedor.id.Length > 0)
                {
                    //CABECERA
                    sw.Write("ID" + '\t');
                    sw.Write("REFERENCIA" + '\t');
                    sw.Write("PROVEEDOR" + '\t');
                    sw.Write("SUCURSAL" + '\t');
                    sw.Write("ESTATUS" + '\n');

                    sw.Write(pedidosProveedor.id + '\t');
                    sw.Write(pedidosProveedor.referencia + '\t');
                    sw.Write(pedidosProveedor.proveedorID + '\t');
                    sw.Write(pedidosProveedor.sucursalID + '\t');
                    sw.Write(pedidosProveedor.estatus + '\n');
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

                    sw.Write(pedidosProveedor.subtotal + '\t');
                    sw.Write(pedidosProveedor.total_iva + '\t');
                    sw.Write(pedidosProveedor.grantotal + '\n');

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

        public String exporta_reporte(PedidosProveedor pedidosProveedor, DataTable ordendetalle)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PedidosProveedor));
            System.IO.StreamWriter sw = null;
            PedidoProveedorDetalle pedidoProveedorDetalle = new PedidoProveedorDetalle();

            try
            {
                if (pedidosProveedor.id.Length > 0)
                {
                    pedidosProveedor.pedidoProveedorDetalle.Clear();
                    foreach (DataRow row in ordendetalle.Rows)
                    {
                        pedidoProveedorDetalle = new PedidoProveedorDetalle();
                        pedidoProveedorDetalle.ean = row["codigo_ean"].ToString();
                        pedidoProveedorDetalle.descripcion = row["descripcion"].ToString();
                        pedidoProveedorDetalle.cantidad = row["cantidad"].ToString();
                        pedidoProveedorDetalle.venta = row["p_venta"].ToString();
                        pedidoProveedorDetalle.costo = row["p_costo"].ToString();
                        pedidoProveedorDetalle.subtotal = row["subtotal"].ToString();
                        pedidoProveedorDetalle.iva = row["iva"].ToString();
                        pedidoProveedorDetalle.total = row["total"].ToString();
                        pedidosProveedor.pedidoProveedorDetalle.Add(pedidoProveedorDetalle);
                    }

                    if (File.Exists("pedidoPOS.xml"))
                        File.Delete("pedidoPOS.xml");
                    sw = new System.IO.StreamWriter("pedidoPOS.xml");
                    serializer.Serialize(sw, pedidosProveedor);
                    pedidosProveedor.pedidoProveedorDetalle.Clear();

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
