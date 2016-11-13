using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class FormasPagoBL
    {
        private FormasPagoDL formasPagoDL = new FormasPagoDL();

        public FormasPagoBL()
        {
            formasPagoDL = new FormasPagoDL();
        }

        public DataTable getPagos(string descripcion, string empresaID)
        {
            DataTable table = formasPagoDL.getPagos(descripcion, empresaID);
            return table;
        }

        public string setPagos(FormasPago formasPago, ref Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = formasPagoDL.existe_pago(formasPago.descripcion, empresaID);
                    if (value > 0)
                        response = "Ya existe la Forma de Pago con ID: " + value.ToString();
                    else
                    {
                        if (formasPagoDL.genera_forma_pago(formasPago, "ins_forma_pago", empresaID) > 0)
                        {
                            response = "Nueva Forma de Pago agregada";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar la Forma de Pago";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (formasPagoDL.genera_forma_pago(formasPago, "upd_forma_pago", empresaID) > 0)
                        response = "Forma de Pago modificada";
                    else
                        response = "Error, no se pudo modificar la Forma de Pago";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaProveedor(FormasPago formasPago)
        {
            if (formasPagoDL.elimina_forma_pago(formasPago) > 0)
                return "Forma de Pago con ID: " + formasPago.id + " borrada";
            else
                return "Forma de Pago con ID: " + formasPago.id + " no pudo ser borrada";
        }
    }
}
