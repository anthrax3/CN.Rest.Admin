using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class ProveedorDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public ProveedorDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getProveedores(string empresaID)
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

            objParameter.strProc = "sel_proveedores";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getProveedoresFiltro(string rfc, string razon, string empresaID)
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
            Parameters.name = "_razon";
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

            objParameter.strProc = "sel_proveedor_filtro";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_proveedor(string rfc, string empresaID)
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

            objParameter.strProc = "sel_existe_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["proveedorID"].ToString());

            return value;
        }

        public int genera_proveedor(Proveedores proveedores, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rfc";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = proveedores.rfc.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = proveedores.razon.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_alias";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = proveedores.alias.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_direccion";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = proveedores.direccion.Trim();
            listParameters.Add(Parameters);

            if (proveedores.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = proveedores.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_almacen";
            Parameters.type = "Int32";
            Parameters.size = "1";
            Parameters.value = Convert.ToInt32(proveedores.almacen).ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
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

        public int eliminaProveedor(Proveedores proveedores)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedores.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_proveedor";
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
