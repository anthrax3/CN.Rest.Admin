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
    public class EntradasBL
    {
        EntradasDL entradasDL = new EntradasDL();

        public EntradasBL()
        {
            entradasDL = new EntradasDL();
        }

        public DataTable getEntradas(string factura, string folio, string empresaID)
        {
            DataTable table = entradasDL.getEntradas(factura, folio, empresaID);
            return table;
        }

        public DataTable getDetalle(string entradaID)
        {
            DataTable table = entradasDL.getDetalle(entradaID);
            return table;
        }

        public void calculaTotal(DataTable tabla, ref decimal _totalCero, ref decimal _totalQuince)
        {
            foreach (DataRow Row in tabla.Rows)
            {
                _totalCero += Convert.ToDecimal(Row["subtotalCero"]);
                _totalQuince += Convert.ToDecimal(Row["subtotalQuince"]);
            }
        }

        public string eliminaEntrada(string entradaID)
        {
            if (entradasDL.eliminaEntrada(entradaID) > 0)
                return "Orden con ID: " + entradaID + " borrada";
            else
                return "Orden con ID: " + entradaID + " no pudo ser borrada";
        }

        public string eliminaDetalle(string ordendetalleID)
        {
            if (entradasDL.eliminaDetalle(ordendetalleID) > 0)
                return "Artículo con ID: " + ordendetalleID + " borrado";
            else
                return "Artículo con ID: " + ordendetalleID + " no pudo ser borrado";
        }

        public string setEntradas(ref Entradas entradas, ref Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = entradasDL.existe_entrada(entradas.factura, entradas.folio, entradas.proveedorID);
                    if (value > 0)
                        response = "Ya existe la Entrada con ID: " + value.ToString();
                    else
                    {
                        if (entradasDL.genera_entrada(entradas, "ins_entrada") > 0)
                        {
                            entradas.entradaID = entradasDL.getEntradaID(entradas.factura, entradas.folio);
                            response = "Nueva Entrada agregada";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar la Orden";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (entradasDL.genera_entrada(entradas, "upd_entrada") > 0)
                        response = "Entrada modificada";
                    else
                        response = "Error, no se pudo modificar la Entrada";
                    break;
                default:
                    break;
            }
            return response;
        }

        public void calculaPartida(decimal costo, decimal cantidad, ref decimal _totalCero, ref decimal _iva, ref decimal _totalQuince)
        {
            _totalCero = (_iva == 0) ? (cantidad * costo) : 0;
            _totalQuince = (_iva > 0) ? (cantidad * costo) * ((_iva / 100) + 1) : 0;
        }

        public string setDetalle(EntradaDetalle entradaDetalle, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = entradasDL.existe_detalle(entradaDetalle.ean, entradaDetalle.entradaID);
                    if (value > 0)
                        response = "Ya existe el Artículo con ID: " + value.ToString();
                    else
                    {
                        if (entradasDL.inserta_detalle(entradaDetalle, "ins_entrada_detalle") > 0)
                            response = "Nueva Artículo agregado";
                        else
                            response = "Error, no se pudo insertar el Artículo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (entradasDL.actualiza_detalle(entradaDetalle, "upd_entrada_detalle") > 0)
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
