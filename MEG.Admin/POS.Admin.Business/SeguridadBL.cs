using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class SeguridadBL
    {
        private SeguridadDL seguridadDL = new SeguridadDL();

        public SeguridadBL()
        {
            seguridadDL = new SeguridadDL();
        }

        public DataTable getRoles(string empresaID)
        {
            DataTable table = seguridadDL.getRoles(empresaID);
            return table;
        }

        public DataTable getUsuarios(string empresaID)
        {
            DataTable table = seguridadDL.getUsuarios(empresaID);
            return table;
        }

        public DataTable getModulos()
        {
            DataTable table = seguridadDL.getModulos();
            return table;
        }

        public string eliminaUsuario(int usuarioID)
        {
            if (seguridadDL.eliminaUsuario(usuarioID) > 0)
                return "usuario con ID: " + usuarioID + " borrado";
            else
                return "usuario con ID: " + usuarioID + " no pudo ser borrado";
        }

        public string eliminaRol(int rolID)
        {
            if (seguridadDL.eliminaRol(rolID) > 0)
                return "rol con ID: " + rolID + " borrado";
            else
                return "rol con ID: " + rolID + " no pudo ser borrado";
        }

        public int insertaRol(string descripcion, string empresaID)
        {
            return seguridadDL.insertaRol(descripcion, empresaID);
        }

        public int insertaUsuario(string usuario, string password, string rolID, string empresaID, string nombre, string paterno, string materno)
        {
            return seguridadDL.insertaUsuario(usuario, password, rolID, empresaID, nombre, paterno, materno);
        }

        public DataTable getPoliticas(int rolID)
        {
            DataTable table = seguridadDL.getPoliticas(rolID);
            return table;
        }

        public string eliminaPolitica(int politicaID)
        {
            if (seguridadDL.eliminaPolitica(politicaID) > 0)
                return "politica con ID: " + politicaID + " borrado";
            else
                return "politica con ID: " + politicaID + " no pudo ser borrado";
        }

        public int insertaPolitica(int rolID, int moduloID, int agregar, int modificar, int eliminar,
            int visualizar)
        {
            return seguridadDL.insertaPolitica(rolID, moduloID, agregar, modificar, eliminar, visualizar);
        }

        public DataTable validaCuenta(string usuario, string password, string llave)
        {
            return seguridadDL.validaCuenta(usuario, password, llave);
        }
    }
}
