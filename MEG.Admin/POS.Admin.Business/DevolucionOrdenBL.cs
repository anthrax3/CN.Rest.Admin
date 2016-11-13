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
    public class DevolucionOrdenBL
    {
        private DevolucionOrdenDL devolucionOrdenDL = new DevolucionOrdenDL();

        public DevolucionOrdenBL()
        {
            devolucionOrdenDL = new DevolucionOrdenDL();
        }

        public DataTable getDevolucionOrden(string devolucionOrdenID, string empresaID)
        {
            devolucionOrdenID = (string.IsNullOrEmpty(devolucionOrdenID) ? "0" : devolucionOrdenID);
            DataTable table = devolucionOrdenDL.getDevolucionOrden(devolucionOrdenID, empresaID);
            return table;
        }

        public DataTable getDevOrdenDetalle(string devolucionOrdenID)
        {
            DataTable table = devolucionOrdenDL.getDevOrdenDetalle(devolucionOrdenID);
            return table;
        }

        public void calculaTotal(DataTable tabla, ref decimal _subtotal, ref decimal _iva, ref decimal _total)
        {
            foreach (DataRow Row in tabla.Rows)
            {
                _subtotal += Convert.ToDecimal(Row["subtotal"]);
                _iva += Convert.ToDecimal(Row["iva"]);
                _total += Convert.ToDecimal(Row["total"]);
            }
        }

        public void calculaPartida(decimal costo, decimal cantidad, ref decimal _subtotal, ref decimal _iva, ref decimal _total)
        {
            _subtotal = (cantidad * costo);
            _iva = (_subtotal * (_iva / 100));
            _total = (_subtotal + _iva);
        }

        public string eliminaDevolucionOrden(DevolucionOrden devolucionOrden)
        {
            if (devolucionOrdenDL.eliminaDevolucionOrden(devolucionOrden) > 0)
                return "Devolución de Orden con ID: " + devolucionOrden.id + " borrada";
            else
                return "Devolución de Orden con ID: " + devolucionOrden.id + " no pudo ser borrada";
        }

        public string setDevolucionOrden(ref DevolucionOrden devolucionOrden, ref Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = devolucionOrdenDL.existe_devolucion_orden(devolucionOrden.noOrden, devolucionOrden.referencia, devolucionOrden.proveedorID);
                    if (value > 0)
                        response = "Ya existe la Devolución de Orden con ID: " + value.ToString();
                    else
                    {
                        if (devolucionOrdenDL.genera_devolucion_orden(devolucionOrden, "ins_devolucion_orden") > 0)
                        {
                            devolucionOrden.id = devolucionOrdenDL.getDevolucionOrdenID();
                            response = "Nueva Devolución de Orden agregada";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar la Devolución de Orden";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (devolucionOrdenDL.genera_devolucion_orden(devolucionOrden, "upd_devolucion_orden") > 0)
                        response = "Devolución de Orden modificada";
                    else
                        response = "Error, no se pudo modificar la Devolución de Orden";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaDevOrdenDetalle(devolucionOrdenDetalle DevolucionOrdenDetalle)
        {
            if (devolucionOrdenDL.eliminaDevOrdenDetalle(DevolucionOrdenDetalle) > 0)
                return "Artículo con ID: " + DevolucionOrdenDetalle.id + " borrado";
            else
                return "Artículo con ID: " + DevolucionOrdenDetalle.id + " no pudo ser borrado";
        }

        public string setDevOrdenDetalle(devolucionOrdenDetalle DevolucionOrdenDetalle, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = devolucionOrdenDL.existe_devolucion_detalle(DevolucionOrdenDetalle.ean, DevolucionOrdenDetalle.devolucionOrdenID);
                    if (value > 0)
                        response = "Ya existe el Artículo con ID: " + value.ToString();
                    else
                    {
                        if (devolucionOrdenDL.inserta_devolucion_detalle(DevolucionOrdenDetalle, "ins_devolucion_orden_detalle") > 0)
                            response = "Nueva Artículo agregado";
                        else
                            response = "Error, no se pudo insertar el Artículo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (devolucionOrdenDL.actualiza_devolucion_detalle(DevolucionOrdenDetalle, "upd_devolucion_orden_detalle") > 0)
                        response = "Artículo modificado";
                    else
                        response = "Error, no se pudo modificar el Artículo";
                    break;
                default:
                    break;
            }
            return response;
        }
    }
}
