using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class ArticulosDL
    {
        private WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public ArticulosDL()
        {
            service = new WSPOS.posservice();
        }

        public DataTable getArticulos(string descripcion, string estatus, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "desc_";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "estat_";
            Parameters.type = "VarChar";
            Parameters.size = "45";
            Parameters.value = estatus.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_articulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getArticulosSubCat(string subCategoriaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_subCategoriaID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = subCategoriaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_articulos_sub_categoria";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getArticulos(string busqueda, int tipo, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_find";
            Parameters.type = "VarChar";
            Parameters.size = "50";
            Parameters.value = busqueda.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_type";
            Parameters.type = "TinyInt";
            Parameters.size = "4";
            Parameters.value = tipo.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_buscar_articulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getArticulosSinProveedor(string busqueda, int tipo, int proveedorID, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_find";
            Parameters.type = "VarChar";
            Parameters.size = "50";
            Parameters.value = busqueda.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_type";
            Parameters.type = "TinyInt";
            Parameters.size = "4";
            Parameters.value = tipo.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_buscar_articulos_sin_prov";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int setNuevoCodigo(string eanActual, string eanNuevo, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_eanActual";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = eanActual.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_eanNuevo";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = eanNuevo.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "upd_Nuevo_Codigo";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public DataTable getEstatus()
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();
            objParameter = new WSPOS.ObjParameters();

            objParameter.strProc = "sel_estatus";
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_articulo(string ean, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_ean";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = ean.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_articulo";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["articuloID"].ToString());

            return value;
        }

        public int genera_articulo(Articulos articulos, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_ean";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = articulos.ean.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_desc";
            Parameters.type = "VarChar";
            Parameters.size = "200";
            Parameters.value = articulos.descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_medida";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = articulos.medida.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_costo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = articulos.costo.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = articulos.venta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_iva";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = articulos.iva.Trim();
            listParameters.Add(Parameters);

            if (articulos.estatus == "ACTIVO")
                articulos.estatus = "1";
            else if (articulos.estatus == "INACTIVO")
                articulos.estatus = "2";
            else
                articulos.estatus = "3";

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = articulos.estatus.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_unidad";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = articulos.unidad.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_grupo";
            Parameters.type = "VarChar";
            Parameters.size = "100";
            Parameters.value = articulos.grupo.Trim();
            listParameters.Add(Parameters);

            if (articulos.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "11";
                Parameters.value = articulos.id.Trim();
                listParameters.Add(Parameters);
            }

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

        public int eliminaArticulo(Articulos articulos, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_id";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = articulos.id.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_articulo";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public DataTable getArticulosProveedor(int proveedorID, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.ToString();
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_articulos_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int delArticuloProv(string ean, int proveedorID, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_proveedorID";
            Parameters.type = "Int32";
            Parameters.size = "4";
            Parameters.value = proveedorID.ToString();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_codigo";
            Parameters.type = "VarChar";
            Parameters.size = "13";
            Parameters.value = ean.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_articulos_proveedor";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value = Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int setImagenCodigo(List<ArticulosImagen> listaArtCodigo, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            listaArtCodigo.ForEach(delegate(ArticulosImagen artCodigo)
            {
                objParameter = new WSPOS.ObjParameters();
                listParameters = new List<WSPOS.Parameters>();

                Parameters = new WSPOS.Parameters();
                Parameters.name = "_ean";
                Parameters.type = "VarChar";
                Parameters.size = "13";
                Parameters.value = artCodigo.ean.Trim();
                listParameters.Add(Parameters);

                Parameters = new WSPOS.Parameters();
                Parameters.name = "_imagen";
                Parameters.type = "Blob";
                Parameters.size = "65000";
                Parameters.value = artCodigo.imagen;
                listParameters.Add(Parameters);

                objParameter.strProc = "upd_codigo_articulo";
                objParameter.ListParameters = listParameters.ToArray();
                listObjParameter.Add(objParameter);
            });

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value += Convert.ToInt32(row["return"].ToString());

            return value;
        }

        public int ins_articulo_proveedor(List<ArticulosProveedor> listaArtProveedor, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            listaArtProveedor.ForEach(delegate(ArticulosProveedor artProveedor)
            {
                objParameter = new WSPOS.ObjParameters();
                listParameters = new List<WSPOS.Parameters>();

                Parameters = new WSPOS.Parameters();
                Parameters.name = "_codigo";
                Parameters.type = "VarChar";
                Parameters.size = "13";
                Parameters.value = artProveedor.ean;
                listParameters.Add(Parameters);

                Parameters = new WSPOS.Parameters();
                Parameters.name = "_proveedorID";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = artProveedor.proveedorID.ToString();
                listParameters.Add(Parameters);

                objParameter.strProc = "ins_articulo_proveedor";
                objParameter.ListParameters = listParameters.ToArray();
                listObjParameter.Add(objParameter);
            });

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.UPDATE, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                value += Convert.ToInt32(row["return"].ToString());

            return value;
        }
    }
}
