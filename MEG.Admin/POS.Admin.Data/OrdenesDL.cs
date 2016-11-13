using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class OrdenesDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public OrdenesDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getOrdenes(string factura, string orden, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_factura";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = factura.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = orden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_ordenes";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getDetalle(string ordenID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_ordenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordenID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_orden_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getArticuloDetalle(string ean, string empresaID)
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
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_un_articulo";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public string getOrdenID(string factura, string noOrden, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_factura";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = factura.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = noOrden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_id_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            string value = string.Empty;
            foreach (DataRow row in table.Rows)
                value = row["ordenID"].ToString();

            return value;
        }

        public int existe_orden(string factura, string noOrden, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_factura";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = factura.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = noOrden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["ordenID"].ToString());

            return value;
        }

        public int existe_detalle(string ean, string ordenID)
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
            Parameters.name = "_ordenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordenID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["detalleID"].ToString());

            return value;
        }

        public int genera_orden(Ordenes ordenes, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (ordenes.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = ordenes.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursal";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = ordenes.sucursalID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedor";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = ordenes.proveedorID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_orden";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = ordenes.noOrden.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_factura";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = ordenes.factura.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordenes.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordenes.total_iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordenes.grantotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = ordenes.estatus.Trim();
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

        public int inserta_detalle(ordenDetalle ordendetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_articuloID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordendetalle.id.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_ordenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordendetalle.ordenID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.total.Trim();
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

        public int actualiza_detalle(ordenDetalle ordendetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (ordendetalle.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_detalleID";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = ordendetalle.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = ordendetalle.total.Trim();
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

        public int eliminaOrden(Ordenes ordenes)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordenes.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_orden";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int eliminaDetalle(ordenDetalle ordendetalle)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordendetalle.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_orden_detalle";
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
