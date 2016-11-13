using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class InventariosDL
    {
        protected WSPOS.posservice service;
        private WSPOS.ArrayParameters arrayParameters;
        private WSPOS.ObjParameters objParameter;
        private List<WSPOS.ObjParameters> listObjParameter;
        private WSPOS.Parameters Parameters;
        private List<WSPOS.Parameters> listParameters;

        public InventariosDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getInventarios(string proveedorID, string descripcion)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_inventarios";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }
    }
}
