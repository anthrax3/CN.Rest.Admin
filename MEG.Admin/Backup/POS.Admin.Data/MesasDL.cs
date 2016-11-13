using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class MesasDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public MesasDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getMesas(string nombre, string sucursalID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombre";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = nombre;
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = sucursalID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_mesas";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_mesa(string mesaID, string sucursalID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombre";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = mesaID;
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = sucursalID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_mesa";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["mesaID"].ToString());
            }

            return value;
        }

        public int generamesa(Mesas mesas, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombre";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = mesas.nombre.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_numero";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = mesas.numero.Trim();
            listParameters.Add(Parameters);

            if (mesas.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = mesas.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = mesas.sucursalID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = strProc;
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

        public int eliminaMesa(Mesas mesas)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = mesas.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_mesa";
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
    }
}
