using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Business;
using POS.Admin.Identities;

namespace POS.Admin.Appl
{
    public static class Globales
    {
        public static string empresaId;
        public static string pathImg;

        //Modificar grids
        public static bool modificaOrden;
        public static bool modificaEntrada;
        public static bool modificaSucursal;
        public static bool modificaProveedor;
        public static bool modificaDevolucion;
        public static bool modificaArticulos;
        public static bool modificaCategorias;
        public static bool modificaPaquetes;
        public static bool modificaCombinaciones;
        public static bool modificaMesa;
        public static bool modificaGrupos;
        public static bool modificaClientes;
        public static bool modificaFormasPago;
        public static bool modificaCuentasCobro;
        public static bool modificaPedidoProveedor;

        public static DataTable tablaArticulos;
        public static List<String> estatus = new List<String>();
        public static DataTable tablaSucursales;
        public static DataTable tablaProveedores;
        public static DataTable tablaRoles = new DataTable();
        public static DataTable tablaInvSucursal;
        public static DataTable tablaUnidades;
        public static DataTable tablaImpuestos;
        public static DataTable tablaCategorias;
        public static DataTable tablaSubCategorias;
        public static DataTable tablaInventarios;
        public static DataTable tablaAccesos;
        public static DataTable tablaGrupos;
        public static DataTable tablaEstados;
        public static DataTable tablaMunicipios;
        public static DataTable tablaFormasPago;

        public static int usuarioID;
        public static int rolID;
        public static int politicaID;
        public static int moduloID;
        public static string rol;
        public static string modulo; 
    }

    public static class CatalogosTemp
    {
        private static ProveedorBL proveedorBL;
        private static SucursalesBL sucursalesBL;
        private static CategoriasBL categoriasBL;
        private static UnidadesBL unidadesBL;
        private static ImpuestosBL impuestosBL;
        private static ArticulosBL articulosBL;
        private static EstadosBL estadosBL;
        private static FormasPagoBL formasPagoBL;

        public static void actualizaCatalogos()
        {
            getProveedores();
            getSucursales();
            getUnidades();
            getCategorias();
            getSubCategorias();
            getImpuestos();
            getEstatus();
            getEstados();
            getMunicipios();
            getFormasPago();
        }

        public static void getProveedores()
        {
            proveedorBL = new ProveedorBL();
            Globales.tablaProveedores = new DataTable();
            Globales.tablaProveedores = proveedorBL.getProveedores(Globales.empresaId);
        }

        public static void getSucursales()
        {
            sucursalesBL = new SucursalesBL();
            Globales.tablaSucursales = new DataTable();
            Globales.tablaSucursales = sucursalesBL.getSucursales("", Globales.empresaId);
        }

        public static void getUnidades()
        {
            unidadesBL = new UnidadesBL();
            Globales.tablaUnidades = new DataTable();
            Globales.tablaUnidades = unidadesBL.getUnidades("");
        }

        public static void getEstatus()
        {
            articulosBL = new ArticulosBL();
            Globales.estatus = new List<String>();
            Globales.estatus = articulosBL.getEstatus();
        }

        public static void getImpuestos()
        {
            impuestosBL = new ImpuestosBL();
            Globales.tablaImpuestos = new DataTable();
            Globales.tablaImpuestos = impuestosBL.getImpuestos("");
        }

        public static void getCategorias()
        {
            categoriasBL = new CategoriasBL();
            Globales.tablaCategorias = new DataTable();
            Globales.tablaCategorias = categoriasBL.getCategorias("", Globales.empresaId);
        }

        public static void getSubCategorias()
        {
            categoriasBL = new CategoriasBL();
            Globales.tablaSubCategorias = new DataTable();
            Globales.tablaSubCategorias = categoriasBL.getSubCategoriasAll(Globales.empresaId);
        }

        public static void getGrupos(string subCategoriaID)
        {
            categoriasBL = new CategoriasBL();
            Globales.tablaGrupos = new DataTable();
            Globales.tablaGrupos = categoriasBL.getGrupos(subCategoriaID);
        }

        public static void getEstados()
        {
            estadosBL = new EstadosBL();
            Globales.tablaEstados = new DataTable();
            Globales.tablaEstados = estadosBL.getEstados();
        }

        public static void getMunicipios()
        {
            estadosBL = new EstadosBL();
            Globales.tablaMunicipios = new DataTable();
            Globales.tablaMunicipios = estadosBL.getMunicipios();
        }

        public static void getFormasPago()
        {
            formasPagoBL = new FormasPagoBL();
            Globales.tablaFormasPago = new DataTable();
            Globales.tablaFormasPago = formasPagoBL.getPagos("", Globales.empresaId);
        }
    }
}
