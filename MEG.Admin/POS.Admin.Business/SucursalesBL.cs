using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class SucursalesBL
    {
        private SucursalesDL sucursalesDL = new SucursalesDL();

        public SucursalesBL()
        {
            sucursalesDL = new SucursalesDL();
        }

        public DataTable getSucursales(string nombre, string empresaID)
        {
            DataTable table = sucursalesDL.getSucursales(nombre, empresaID);
            return table;
        }

        public string setSucursales(Sucursales sucursales, Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = sucursalesDL.existe_sucursal(sucursales.codigo, empresaID);
                    if (value > 0)
                        response = "Ya existe la Sucursal con ID: " + value.ToString();
                    else
                    {
                        if (sucursalesDL.genera_sucursal(sucursales, "ins_sucursal", empresaID) > 0)
                            response = "Nuevo Sucursal agregada";
                        else
                            response = "Error, no se pudo insertar la Sucursal";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (sucursalesDL.genera_sucursal(sucursales, "upd_sucursal", empresaID) > 0)
                        response = "Sucursal modificada";
                    else
                        response = "Error, no se pudo modificar la Sucursal";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaSucursal(Sucursales sucursales)
        {
            if (sucursalesDL.eliminaSucursal(sucursales) > 0)
                return "Sucursal con ID: " + sucursales.id + " borrada";
            else
                return "Sucursal con ID: " + sucursales.id + " no pudo ser borrada";
        }
    }
}
