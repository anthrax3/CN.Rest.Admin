using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class PedidosProveedorDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public PedidosProveedorDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getPedidos(string referencia, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_pedidos_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getDetalle(string pedidoID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_pedidoID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidoID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_pedido_proveedor_detalle";
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

        public string getpedidoID(string referencia, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_id_pedido_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            string value = string.Empty;
            foreach (DataRow row in table.Rows)
                value = row["pedidoID"].ToString();

            return value;
        }

        public int existe_pedido(string referencia, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_pedido_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["pedidoID"].ToString());

            return value;
        }

        public int existe_detalle(string ean, string pedidoID)
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
            Parameters.name = "_pedidoID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidoID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_pedido_proveedor_detalle";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["detallePedidoID"].ToString());

            return value;
        }

        public int genera_pedido_proveedor(PedidosProveedor pedidosProveedor, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (pedidosProveedor.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = pedidosProveedor.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursal";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = pedidosProveedor.sucursalID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedor";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = pedidosProveedor.proveedorID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_referencia";
            Parameters.type = "VarChar";
            Parameters.size = "30";
            Parameters.value = pedidosProveedor.referencia.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidosProveedor.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidosProveedor.total_iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidosProveedor.grantotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = pedidosProveedor.estatus.Trim();
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

        public int inserta_detalle(PedidoProveedorDetalle pedidoProveedorDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_articuloID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidoProveedorDetalle.id.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_pedidoID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidoProveedorDetalle.pedidoID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.total.Trim();
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

        public int actualiza_detalle(PedidoProveedorDetalle pedidoProveedorDetalle, string strProc)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            if (pedidoProveedorDetalle.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_detalleID";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = pedidoProveedorDetalle.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_cantidad";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.cantidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_subtotal";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.subtotal.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.iva.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_total";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = pedidoProveedorDetalle.total.Trim();
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

        public int eliminaPedidoProveedor(PedidosProveedor pedidosProveedor)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidosProveedor.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_pedido_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int eliminaDetalle(PedidoProveedorDetalle pedidoProveedorDetalle)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = pedidoProveedorDetalle.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_pedido_proveedor_detalle";
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
