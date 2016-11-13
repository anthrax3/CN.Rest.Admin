using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class ClientesBL
    {
        private ClientesDL clientesDL = new ClientesDL();

        public ClientesBL()
        {
            clientesDL = new ClientesDL();
        }

        public DataTable getClientes(string empresaID)
        {
            DataTable table = clientesDL.getClientes(empresaID);
            return table;
        }

        public DataTable getClientesfiltro(string rfc, string razon, string empresaID)
        {
            DataTable table = clientesDL.getClientesFiltro(rfc, razon, empresaID);
            return table;
        }

        public string setClientes(Clientes clientes, ref Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = clientesDL.existe_cliente(clientes.rfc, empresaID);
                    if (value > 0)
                        response = "Ya existe el Cliente con ID: " + value.ToString();
                    else
                    {
                        if (clientesDL.genera_cliente(clientes, "ins_cliente", empresaID) > 0)
                        {
                            response = "Nuevo Cliente agregado";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar el Cliente";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (clientesDL.genera_cliente(clientes, "upd_cliente", empresaID) > 0)
                        response = "Cliente modificado";
                    else
                        response = "Error, no se pudo modificar el Cliente";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaCliente(Clientes clientes)
        {
            if (clientesDL.eliminaCliente(clientes) > 0)
                return "Cliente con ID: " + clientes.id + " borrado";
            else
                return "Cliente con ID: " + clientes.id + " no pudo ser borrado";
        }
    }
}
