using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class MesasBL
    {
        private MesasDL mesasDL = new MesasDL();

        public MesasBL()
        {
            mesasDL = new MesasDL();
        }

        public DataTable getMesas(string nombre, string sucursalID)
        {
            DataTable table = mesasDL.getMesas(nombre, sucursalID);
            return table;
        }

        public string setMesas(Mesas mesas, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = mesasDL.existe_mesa(mesas.id, mesas.sucursalID);
                    if (value > 0)
                        response = "Ya existe la Mesa con ID: " + value.ToString();
                    else
                    {
                        if (mesasDL.generamesa(mesas, "ins_mesa") > 0)
                            response = "Nuevo Mesa agregada";
                        else
                            response = "Error, no se pudo insertar la Mesa";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (mesasDL.generamesa(mesas, "upd_mesa") > 0)
                        response = "Mesa modificada";
                    else
                        response = "Error, no se pudo modificar la Mesa";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaMesa(Mesas mesas)
        {
            if (mesasDL.eliminaMesa(mesas) > 0)
                return "Mesa con ID: " + mesas.id + " borrada";
            else
                return "Mesa con ID: " + mesas.id + " no pudo ser borrada";
        }
    }
}
