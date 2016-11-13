using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class ProveedorBL
    {
        private ProveedorDL proveedorDL = new ProveedorDL();

        public ProveedorBL()
        {
            proveedorDL = new ProveedorDL();
        }

        public DataTable getProveedores(string empresaID)
        {
            DataTable table = proveedorDL.getProveedores(empresaID);
            return table;
        }

        public DataTable getProveedoresfiltro(string rfc, string razon, string empresaID)
        {
            DataTable table = proveedorDL.getProveedoresFiltro(rfc, razon, empresaID);
            return table;
        }

        public string setProveedores(Proveedores proveedores, ref Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = proveedorDL.existe_proveedor(proveedores.rfc, empresaID);
                    if (value > 0)
                        response = "Ya existe el Proveedor con ID: " + value.ToString();
                    else
                    {
                        if (proveedorDL.genera_proveedor(proveedores, "ins_proveedor", empresaID) > 0)
                        {
                            response = "Nuevo Proveedor agregado";
                            tipoTransaccion = Objetos.TipoTransaccion.UPDATE;
                        }
                        else
                            response = "Error, no se pudo insertar el Proveedor";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (proveedorDL.genera_proveedor(proveedores, "upd_proveedor", empresaID) > 0)
                        response = "Proveedor modificado";
                    else
                        response = "Error, no se pudo modificar el Proveedor";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaProveedor(Proveedores proveedores)
        {
            if (proveedorDL.eliminaProveedor(proveedores) > 0)
                return "Proveedor con ID: " + proveedores.id + " borrado";
            else
                return "Proveedor con ID: " + proveedores.id + " no pudo ser borrado";
        }
    }
}
