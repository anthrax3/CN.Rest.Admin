using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class PaquetesBL
    {
        private PaquetesDL paquetesDL;
        private Combinaciones combinaciones;

        public PaquetesBL()
        {
            paquetesDL = new PaquetesDL();
        }

        #region Paquetes

        public DataTable getPaquetes(string descripcion, string empresaID)
        {
            DataTable table = paquetesDL.getPaquetes(descripcion, empresaID);
            return table;
        }

        public DataTable getPaquetesArticulos(string paqueteID)
        {
            DataTable table = paquetesDL.getPaquetesArticulos(paqueteID);
            return table;
        }

        public DataTable getPaquetesSubCategorias(string paqueteID)
        {
            DataTable table = paquetesDL.getPaquetesSubCategorias(paqueteID);
            return table;
        }

        public string setPaquetes(Paquetes paquetes, Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = paquetesDL.existe_paquete(paquetes.descripcion, empresaID);
                    if (value > 0)
                        response = "Ya existe el Paquete con ID: " + value.ToString();
                    else
                    {
                        if (paquetesDL.genera_paquete(paquetes, "ins_paquete", empresaID) > 0)
                            response = "Nuevo Paquete agregado";
                        else
                            response = "Error, no se pudo insertar el Paquete";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (paquetesDL.genera_paquete(paquetes, "upd_paquete", empresaID) > 0)
                        response = "Paquete modificado";
                    else
                        response = "Error, no se pudo modificar el Paquete";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaPaquete(string paqueteID)
        {
            if (paquetesDL.eliminaPaquete(paqueteID) > 0)
                return "Paquete con ID: " + paqueteID + " borrado";
            else
                return "Paquete con ID: " + paqueteID + " no pudo ser borrado";
        }

        #endregion Paquetes

        #region Combinaciones

        public DataTable getCombinaciones(string descripcion, string empresaID)
        {
            DataTable table = paquetesDL.getCombinaciones(descripcion, empresaID);
            return table;
        }

        public DataTable getCombinacionesGrupos(string combinacionID)
        {
            DataTable table = paquetesDL.getCombinacionesGrupos(combinacionID);
            return table;
        }

        public DataTable getCombinacionesSubCategorias(string combinacionID)
        {
            DataTable table = paquetesDL.getCombinacionesSubCategorias(combinacionID);
            return table;
        }

        public string setCombinaciones(Combinaciones combinaciones, Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = paquetesDL.existe_combinacion(combinaciones.descripcion, empresaID);
                    if (value > 0)
                        response = "Ya existe la Combinacion con ID: " + value.ToString();
                    else
                    {
                        if (paquetesDL.genera_combinacion(combinaciones, "ins_combinacion", empresaID) > 0)
                            response = "Nueva Combinacion agregada";
                        else
                            response = "Error, no se pudo insertar la Combinacion";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (paquetesDL.genera_combinacion(combinaciones, "upd_combinacion", empresaID) > 0)
                        response = "Combinacion modificada";
                    else
                        response = "Error, no se pudo modificar la Combinacion";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaCombinacion(string CombinacionID)
        {
            if (paquetesDL.eliminaCombinacion(CombinacionID) > 0)
                return "Combinacion con ID: " + CombinacionID + " borrada";
            else
                return "Combinacion con ID: " + CombinacionID + " no pudo ser borrada";
        }

        #endregion Combinaciones

    }
}
