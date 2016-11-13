using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Identities;
//using Crypto = POS.Security.Cryptography;

namespace POS.Admin.Data
{
    public class PaquetesDL
    {
        protected WSPOS.posservice service;
        WSPOS.ArrayParameters arrayParameters;
        WSPOS.ObjParameters objParameter;
        List<WSPOS.ObjParameters> listObjParameter;
        WSPOS.Parameters Parameters;
        List<WSPOS.Parameters> listParameters;

        public PaquetesDL()
        {
            service = new WSPOS.posservice();
        }

        #region Paquetes

        public DataTable getPaquetes(string descripcion, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_paquetesVr2";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getPaquetesArticulos(string paqueteID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_paqueteID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = paqueteID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_paquetes_articulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getPaquetesSubCategorias(string paqueteID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_paqueteID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = paqueteID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_paquetes_subcat";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_paquete(string descripcion, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "80";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_paquete";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["paqueteID"].ToString());
            }

            return value;
        }

        private string rellenastring(string valor)
        {
            if (valor.Length == 1)
                valor = "0" + valor;

            return valor;
        }

        public int genera_paquete(Paquetes paquetes, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "80";
            Parameters.value = paquetes.descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_precio_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = paquetes.precioVenta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_noArticulos";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = paquetes.noArticulos.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_categoriaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = paquetes.categoria.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = paquetes.estatus.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_horaInicio";
            Parameters.type = "VarChar";
            Parameters.size = "10";
            Parameters.value = rellenastring(Convert.ToDateTime(paquetes.horaInicio).Hour.ToString()) +
                ":" + rellenastring(Convert.ToDateTime(paquetes.horaInicio).Minute.ToString()) + ":" +
                rellenastring(Convert.ToDateTime(paquetes.horaInicio).Second.ToString());
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_horaFin";
            Parameters.type = "VarChar";
            Parameters.size = "10";
            Parameters.value = rellenastring(Convert.ToDateTime(paquetes.horaFin).Hour.ToString()) +
                ":" + rellenastring(Convert.ToDateTime(paquetes.horaFin).Minute.ToString()) + ":" +
                rellenastring(Convert.ToDateTime(paquetes.horaFin).Second.ToString());
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_consumo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = paquetes.consumo.Trim();
            listParameters.Add(Parameters);

            if (paquetes.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = paquetes.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = paquetes.sucursal.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = strProc;
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                paquetes.id = row["lastId"].ToString();

            if (Convert.ToInt32(paquetes.id) > 0)
            {
                arrayParameters = new WSPOS.ArrayParameters();
                listObjParameter = new List<WSPOS.ObjParameters>();

                //Articulos
                foreach (PaqueteArticulo paqueteArticulo in paquetes.paqueteArticulo)
                {
                    objParameter = new WSPOS.ObjParameters();
                    listParameters = new List<WSPOS.Parameters>();

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_paqueteID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = paquetes.id;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_articulo";
                    Parameters.type = "VarChar";
                    Parameters.size = "13";
                    Parameters.value = paqueteArticulo.codigoArticulo;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_empresaID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = empresaID;
                    listParameters.Add(Parameters);

                    objParameter.strProc = "ins_paquete_articulos";
                    objParameter.ListParameters = listParameters.ToArray();
                    listObjParameter.Add(objParameter);
                }

                arrayParameters.objParameters = listObjParameter.ToArray();

                DataTable tableArts = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

                foreach (DataRow row in tableArts.Rows)
                    value += Convert.ToInt32(row["return"].ToString());

                arrayParameters = new WSPOS.ArrayParameters();
                listObjParameter = new List<WSPOS.ObjParameters>();

                //SubCategorias
                foreach (PaqueteMezcladores paqueteMezcladores in paquetes.paqueteMezcladores)
                {
                    objParameter = new WSPOS.ObjParameters();
                    listParameters = new List<WSPOS.Parameters>();

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_paqueteID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = paquetes.id;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_articulo";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = paqueteMezcladores.subCategoriaID;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_cantidad";
                    Parameters.type = "Decimal";
                    Parameters.size = "10";
                    Parameters.value = paqueteMezcladores.cantidad;
                    listParameters.Add(Parameters);

                    objParameter.strProc = "ins_paquete_subcategorias";
                    objParameter.ListParameters = listParameters.ToArray();
                    listObjParameter.Add(objParameter);
                }

                arrayParameters.objParameters = listObjParameter.ToArray();

                DataTable tableSubCats = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

                foreach (DataRow row in tableSubCats.Rows)
                    value += Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int eliminaPaquete(string paqueteID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_paqueteID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = paqueteID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_paquete";
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

        #endregion Paquetes

        #region Combinaciones

        public DataTable getCombinaciones(string descripcion, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            Parameters = new WSPOS.Parameters();
            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "250";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_combinacionesVr2";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getCombinacionesGrupos(string combinacionID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_combinacionID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = combinacionID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_combinaciones_grupos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public DataTable getCombinacionesSubCategorias(string combinacionID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_combinacionID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = combinacionID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_combinaciones_subcat";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            return table;
        }

        public int existe_combinacion(string descripcion, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "80";
            Parameters.value = descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            objParameter.strProc = "sel_existe_combinacion";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
            {
                value = Convert.ToInt32(row["combinacionID"].ToString());
            }

            return value;
        }

        public int genera_combinacion(Combinaciones combinaciones, string strProc, string empresaID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_descripcion";
            Parameters.type = "VarChar";
            Parameters.size = "80";
            Parameters.value = combinaciones.descripcion.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_precio_venta";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = combinaciones.precioVenta.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_categoriaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = combinaciones.categoria.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_estatus";
            Parameters.type = "VarChar";
            Parameters.size = "20";
            Parameters.value = combinaciones.estatus.Trim();
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_horaInicio";
            Parameters.type = "VarChar";
            Parameters.size = "10";
            Parameters.value = rellenastring(Convert.ToDateTime(combinaciones.horaInicio).Hour.ToString()) +
                ":" + rellenastring(Convert.ToDateTime(combinaciones.horaInicio).Minute.ToString()) + ":" +
                rellenastring(Convert.ToDateTime(combinaciones.horaInicio).Second.ToString());
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_horaFin";
            Parameters.type = "VarChar";
            Parameters.size = "10";
            Parameters.value = rellenastring(Convert.ToDateTime(combinaciones.horaFin).Hour.ToString()) +
                ":" + rellenastring(Convert.ToDateTime(combinaciones.horaFin).Minute.ToString()) + ":" +
                rellenastring(Convert.ToDateTime(combinaciones.horaFin).Second.ToString());
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_consumo";
            Parameters.type = "Decimal";
            Parameters.size = "10";
            Parameters.value = combinaciones.consumo.Trim();
            listParameters.Add(Parameters);

            if (combinaciones.id != string.Empty)
            {
                Parameters = new WSPOS.Parameters();
                Parameters.name = "_id";
                Parameters.type = "Int32";
                Parameters.size = "4";
                Parameters.value = combinaciones.id.Trim();
                listParameters.Add(Parameters);
            }

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_empresaID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = empresaID;
            listParameters.Add(Parameters);

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_sucursalID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = combinaciones.sucursal.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = strProc;
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            DataTable table = service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);

            int value = 0;
            foreach (DataRow row in table.Rows)
                combinaciones.id = row["lastId"].ToString();

            if (Convert.ToInt32(combinaciones.id) > 0)
            {
                arrayParameters = new WSPOS.ArrayParameters();
                listObjParameter = new List<WSPOS.ObjParameters>();

                //Articulos
                foreach (CombinacionGrupo combinacionGrupo in combinaciones.combinacionGrupo)
                {
                    objParameter = new WSPOS.ObjParameters();
                    listParameters = new List<WSPOS.Parameters>();

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_combinacionID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = combinaciones.id;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_grupoID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = combinacionGrupo.grupoID;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_cantidad";
                    Parameters.type = "Decimal";
                    Parameters.size = "10";
                    Parameters.value = combinacionGrupo.cantidad;
                    listParameters.Add(Parameters);

                    objParameter.strProc = "ins_combinacion_grupos";
                    objParameter.ListParameters = listParameters.ToArray();
                    listObjParameter.Add(objParameter);
                }

                arrayParameters.objParameters = listObjParameter.ToArray();

                DataTable tableArts = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

                foreach (DataRow row in tableArts.Rows)
                    value += Convert.ToInt32(row["return"].ToString());

                arrayParameters = new WSPOS.ArrayParameters();
                listObjParameter = new List<WSPOS.ObjParameters>();

                //SubCategorias
                foreach (CombinacionMezcladores combinacionMezcladores in combinaciones.combinacionMezcladores)
                {
                    objParameter = new WSPOS.ObjParameters();
                    listParameters = new List<WSPOS.Parameters>();

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_combinacionID";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = combinaciones.id;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_articulo";
                    Parameters.type = "Int32";
                    Parameters.size = "11";
                    Parameters.value = combinacionMezcladores.subCategoriaID;
                    listParameters.Add(Parameters);

                    Parameters = new WSPOS.Parameters();
                    Parameters.name = "_cantidad";
                    Parameters.type = "Decimal";
                    Parameters.size = "10";
                    Parameters.value = combinacionMezcladores.cantidad;
                    listParameters.Add(Parameters);

                    objParameter.strProc = "ins_combinacion_subcategorias";
                    objParameter.ListParameters = listParameters.ToArray();
                    listObjParameter.Add(objParameter);
                }

                arrayParameters.objParameters = listObjParameter.ToArray();

                DataTable tableSubCats = service.setTransactionsArray(WSPOS.TransactionDb.INSERT, arrayParameters);

                foreach (DataRow row in tableSubCats.Rows)
                    value += Convert.ToInt32(row["return"].ToString());
            }

            return value;
        }

        public int eliminaCombinacion(string combinacionID)
        {
            arrayParameters = new WSPOS.ArrayParameters();
            listObjParameter = new List<WSPOS.ObjParameters>();

            objParameter = new WSPOS.ObjParameters();
            listParameters = new List<WSPOS.Parameters>();

            Parameters = new WSPOS.Parameters();
            Parameters.name = "_combinacionID";
            Parameters.type = "Int32";
            Parameters.size = "11";
            Parameters.value = combinacionID.Trim();
            listParameters.Add(Parameters);

            objParameter.strProc = "del_combinacion";
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

        #endregion Combinaciones

    
    }
}
