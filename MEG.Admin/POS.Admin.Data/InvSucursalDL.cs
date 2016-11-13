using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
////using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class InvSucursalDL
    {
        protected WSPOS.posservice service;
        private WSPOS.ArrayParameters arrayParameters;
        private WSPOS.ObjParameters objParameter;
        private List<WSPOS.ObjParameters> listObjParameter;
        private WSPOS.Parameters Parameters;
        private List<WSPOS.Parameters> listParameters;

        public InvSucursalDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getInvSucursal(string sucursalID, string descripcion)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = sucursalID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_desc";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_stocks_sucursales";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int setSolicitaCarga(string sucursalID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = sucursalID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "ins_stock_sucursal";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }
    }
}
