using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class SeguridadDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public SeguridadDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getRoles(string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_roles";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getUsuarios(string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_usuarios";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getModulos()
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            objParameter.strProc = "sel_modulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int eliminaUsuario(int usuarioID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_usuarioID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = usuarioID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_usuario";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int eliminaRol(int rolID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rolID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = rolID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_rol";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int insertaRol(string descripcion, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "150";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "ins_rol";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int insertaUsuario(string usuario, string password, string rolID, string empresaID, string nombre, string paterno, string materno)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_usuario";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = usuario.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_password";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = password.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rolID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = rolID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombre";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = nombre.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_paterno";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = paterno.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_materno";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = materno.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "ins_usuario";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public DataTable getPoliticas(int rolID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rolID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = rolID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_politicas";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int eliminaPolitica(int politicaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_politicaID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = politicaID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_politica";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int insertaPolitica(int rolID, int moduloID, int agregar, int modificar, int eliminar,
            int visualizar)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rolID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = rolID.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_moduloID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = moduloID.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_agregar";
            Parameters.type = "Int16";
            Parameters.size = "1";
            Parameters.value = agregar.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_modificar";
            Parameters.type = "Int16";
            Parameters.size = "1";
            Parameters.value = modificar.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_eliminar";
            Parameters.type = "Int16";
            Parameters.size = "1";
            Parameters.value = eliminar.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_visualizar";
            Parameters.type = "Int16";
            Parameters.size = "1";
            Parameters.value = visualizar.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "ins_politica";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public DataTable validaCuenta(string usuario, string password, string llave)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_usuario";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = usuario.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_password";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = password.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_llave";
            Parameters.type = "VarChar";
            Parameters.size = "150";
            Parameters.value = llave.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_rol_cuenta";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }
    }
}
