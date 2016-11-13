using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class DevolucionOrdenDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public DevolucionOrdenDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getDevolucionOrden(string devolucionOrdenID, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_devolucionOrdenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = devolucionOrdenID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_devolucion_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getDevOrdenDetalle(string devolucionOrdenID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_devolucionOrdenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = devolucionOrdenID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_devolucion_orden_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int eliminaDevolucionOrden(DevolucionOrden devolucionOrden)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_devolucionOrdenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = devolucionOrden.id.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = devolucionOrden.estatus.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_devolucion_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int existe_devolucion_orden(string noOrden, string referencia, string proveedorID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = noOrden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_devolucion_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["devolucionOrdenID"].ToString());

            return value;
        }

        public int genera_devolucion_orden(DevolucionOrden devolucionOrden, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (devolucionOrden.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = devolucionOrden.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursal";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = devolucionOrden.sucursalID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedor";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = devolucionOrden.proveedorID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = devolucionOrden.noOrden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = devolucionOrden.referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = devolucionOrden.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = devolucionOrden.total_iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = devolucionOrden.grantotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = devolucionOrden.estatus.Trim();
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

        public string getDevolucionOrdenID()
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();

            objParameter.strProc = "sel_id_devolucion_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            string value = string.Empty;
            foreach (DataRow row in table.Rows)
                value = row["devolucionOrdenID"].ToString();

            return value;
        }

        public int eliminaDevOrdenDetalle(devolucionOrdenDetalle DevolucionOrdenDetalle)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = DevolucionOrdenDetalle.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_devolucion_orden_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int existe_devolucion_detalle(string ean, string devolucionOrdenID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_ean";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = ean.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_devolucionOrdenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = devolucionOrdenID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_dev_orden_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["detalleID"].ToString());

            return value;
        }

        public int inserta_devolucion_detalle(devolucionOrdenDetalle DevolucionOrdenDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_articuloID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = DevolucionOrdenDetalle.id.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_devolucionOrdenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = DevolucionOrdenDetalle.devolucionOrdenID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.total.Trim();
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

        public int actualiza_devolucion_detalle(devolucionOrdenDetalle DevolucionOrdenDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (DevolucionOrdenDetalle.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_detalleID";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = DevolucionOrdenDetalle.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = DevolucionOrdenDetalle.total.Trim();
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
    }
}
