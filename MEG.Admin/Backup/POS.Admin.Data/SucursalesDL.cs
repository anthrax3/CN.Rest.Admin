using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class SucursalesDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public SucursalesDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getSucursales(string nombre, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_nomb";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = nombre.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_sucursales";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_sucursal(string codigo, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cod";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = codigo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_sucursal";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["sucursalID"].ToString());
            }

            return value;
        }

        public int genera_sucursal(Sucursales sucursales, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_calle";
            Parameters.type = "VarChar";
            Parameters.size = "200";
            Parameters.value = sucursales.calle.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_codigo";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = sucursales.codigo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_colonia";
            Parameters.type = "VarChar";
            Parameters.size = "50";
            Parameters.value = sucursales.colonia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cp";
            Parameters.type = "VarChar";
            Parameters.size = "5";
            Parameters.value = sucursales.cp.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_impuestoID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = sucursales.impuestoID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_municipioID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = sucursales.municipioID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_noExt";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = sucursales.noExt.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_noInt";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = sucursales.noInt.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_nombre";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = sucursales.nombre.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_pie";
            Parameters.type = "VarChar";
            Parameters.size = "200";
            Parameters.value = sucursales.pie.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_razon_social";
            Parameters.type = "VarChar";
            Parameters.size = "200";
            Parameters.value = sucursales.razon_social.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_rfc";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = sucursales.rfc.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_telefono";
            Parameters.type = "VarChar";
            Parameters.size = "15";
            Parameters.value = sucursales.telefono.Trim();
            listParameters.Add(Parameters);

            if (sucursales.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = sucursales.id.Trim();
                listParameters.Add(Parameters);
            }

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
            {
                value = Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int eliminaSucursal(Sucursales sucursales)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = sucursales.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_sucursal";
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
