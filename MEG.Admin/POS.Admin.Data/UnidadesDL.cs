using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class UnidadesDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public UnidadesDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getUnidades(string nombre)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_abreviatura";
            Parameters.type = "VarChar";
            Parameters.size = "10";
            Parameters.value = nombre.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_unidades";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }
    }
}
