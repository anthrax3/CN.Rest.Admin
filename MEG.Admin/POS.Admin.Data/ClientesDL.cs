using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class ClientesDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public ClientesDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getClientes(string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_clientes";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getClientesFiltro(string rfc, string razon, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters.name = "_rfc";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = rfc.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_razonSocial";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = razon.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_clientes_filtro";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_cliente(string rfc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_rfc";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = rfc.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_cliente";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["clienteID"].ToString());

            return value;
        }

        public int genera_cliente(Clientes clientes, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rfc";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = clientes.rfc.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombreComercial";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = clientes.nombreComercial.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_razonSocial";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = clientes.razonSocial.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_calle";
            Parameters.type = "VarChar";
            Parameters.size = "150";
            Parameters.value = clientes.calle.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_noExt";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = clientes.noExt.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_noInt";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = clientes.noInt.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_colonia";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = clientes.colonia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cp";
            Parameters.type = "VarChar";
            Parameters.size = "6";
            Parameters.value = clientes.cp.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_municipioID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = clientes.municipioID.Trim();
            listParameters.Add(Parameters);

            if (clientes.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = clientes.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_distribuidor";
            Parameters.type = "Int32";
            Parameters.size = "1";
            Parameters.value = (clientes.distribuidor.ToLower() == "true") ? "1" : "0";
            listParameters.Add(Parameters);

            objParameter.strProc = strProc;
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int eliminaCliente(Clientes clientes)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = clientes.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_cliente";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }
    }
}
