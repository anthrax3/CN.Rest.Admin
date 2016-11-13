using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class EntradasDL
    {
        protected WSPOS.posservice service;
        private WSPOS.ArrayParameters arrayParameters;
        private WSPOS.ObjParameters objParameter;
        private List<WSPOS.ObjParameters> listObjParameter;
        private WSPOS.Parameters Parameters;
        private List<WSPOS.Parameters> listParameters;

        public EntradasDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getEntradas(string factura, string folio, string empresaID)
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
            Parameters.name = "_folio";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = folio.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_entradas";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getDetalle(string entradaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_entradaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = entradaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_entrada_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int eliminaEntrada(string entradaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_entradaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = entradaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_entrada";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int eliminaDetalle(string ordendetalleID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_ordendetalleID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = ordendetalleID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_entrada_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int existe_entrada(string factura, string folio, string proveedorID)
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
            Parameters.name = "_folio";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = folio.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_entrada";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["almacenID"].ToString());

            return value;
        }

        public int genera_entrada(Entradas entradas, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (entradas.entradaID != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = entradas.entradaID.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedor";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = entradas.proveedorID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_folio";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = entradas.folio.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_factura";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = entradas.factura.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalCero";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradas.importeCero.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalQuince";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradas.importeQuince.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = entradas.estatus.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedor_compraID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = entradas.proveedor_compraID.Trim();
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

        public string getEntradaID(string factura, string folio)
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
            Parameters.name = "_folio";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = folio.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_id_entrada";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            string value = string.Empty;
            foreach (DataRow row in table.Rows)
                value = row["almacenID"].ToString();

            return value;
        }

        public int existe_detalle(string ean, string almacenID)
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
            Parameters.name = "_almacenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = almacenID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_entrada_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["detalleAlmacenID"].ToString());

            return value;
        }

        public int inserta_detalle(EntradaDetalle entradaDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_articuloID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = entradaDetalle.id.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_almacenID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = entradaDetalle.entradaID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.porcentaje_iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalCero";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.subtotalCero.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalQuince";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.subtotalQuince.Trim();
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

        public int actualiza_detalle(EntradaDetalle entradaDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (entradaDetalle.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_detalleAlmacenID";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = entradaDetalle.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.porcentaje_iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalCero";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.subtotalCero.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_totalQuince";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = entradaDetalle.subtotalQuince.Trim();
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
