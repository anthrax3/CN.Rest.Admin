using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;
using POS.Admin.Identities;
using System.IO;

namespace POS.Admin.Appl
{
    public partial class UCCatalogos : UserControl
    {
        private ArticulosBL articulosBL;
        private Articulos articulos;

        private SucursalesBL sucursalesBL;
        private Sucursales sucursales;

        private ProveedorBL proveedorBL;
        private Proveedores proveedores;

        private UnidadesBL unidadesBL;

        private ImpuestosBL impuestosBL;

        private CategoriasBL categoriasBL;
        private Categorias categorias;
        private SubCategorias subCategorias;
        private Grupos grupos;

        private PaquetesBL paquetesBL;
        private Paquetes paquetes;
        private Combinaciones combinaciones;

        private Mesas mesas;
        private MesasBL mesasBL;

        private DataTable tableSucursales;

        private ClientesBL clientesBL;
        private Clientes clientes;

        private FormasPagoBL formasPagoBL;
        private FormasPago formasPago;

        public UCCatalogos()
        {
            InitializeComponent();
        }

        public void aplicaPoliticas()
        {
            articulosBL = new ArticulosBL();
            articulos = new Articulos();
            sucursalesBL = new SucursalesBL();
            sucursales = new Sucursales();
            proveedorBL = new ProveedorBL();
            proveedores = new Proveedores();
            unidadesBL = new UnidadesBL();
            impuestosBL = new ImpuestosBL();
            categoriasBL = new CategoriasBL();
            categorias = new Categorias();
            subCategorias = new SubCategorias();
            paquetesBL = new PaquetesBL();
            paquetes = new Paquetes();
            combinaciones = new Combinaciones();
            mesas = new Mesas();
            mesasBL = new MesasBL();
            clientesBL = new ClientesBL();
            clientes = new Clientes();
            formasPagoBL = new FormasPagoBL();
            formasPago = new FormasPago();

            CBEstatus.Items.Clear();
            CBEstatus.Items.AddRange(Globales.estatus.ToArray());

            listarSucursales();
            listarSubCategorias();
            removeTabs();

            foreach (DataRow row in Globales.tablaAccesos.Rows)
            {
                switch (row["modulo"].ToString())
                {
                    case "ARTICULOS":
                        TabCatalogs.TabPages.Add(tabArticulos);
                        BTNuevo.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaArticulos = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminar.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaArt.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "SUCURSALES":
                        TabCatalogs.TabPages.Add(tabSucursales);
                        BTNuevaSuc.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaSucursal = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaSuc.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaSuc.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "PAQUETES":
                        TabCatalogs.TabPages.Add(tabPaquetes);
                        BTNuevoPaquete.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaPaquetes = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminarPaquete.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscarPaquete.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "COMBINACIONES":
                        TabCatalogs.TabPages.Add(tabCombinaciones);
                        btNuevaCombinacion.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaCombinaciones = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminarCombinacion.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaCombinacion.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "CATEGORIAS":
                        TabCatalogs.TabPages.Add(tabCategorias);
                        BTNuevaCat.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaCategorias = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaCat.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaCat.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "GRUPOS":
                        TabCatalogs.TabPages.Add(tabGrupos);
                        btNuevoGrupo.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaGrupos = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaGrupo.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaGrupo.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "CLIENTES":
                        TabCatalogs.TabPages.Add(tabClientes);
                        btNuevoCliente.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaClientes = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaCliente.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaCliente.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "PROVEEDORES":
                        TabCatalogs.TabPages.Add(tabProveedores);
                        btNuevoProv.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaProveedor = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaProv.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaProv.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "MESAS":
                        TabCatalogs.TabPages.Add(tabMesas);
                        btNuevaMesa.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaMesa = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaMesa.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscarMesa.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "FORMAS DE PAGO":
                        TabCatalogs.TabPages.Add(tabPagos);
                        btNuevoPago.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaFormasPago = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaPago.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaPago.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void listarSucursales()
        {
            try
            {
                cbSucursalesMesas.Items.Clear();
                tableSucursales = sucursalesBL.getSucursales("", Globales.empresaId);
                foreach (DataRow row in tableSucursales.Rows)
                {
                    cbSucursalesMesas.Items.Add(row["nombre"].ToString());
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarSubCategorias()
        {
            try
            {
                cbSubCategorias.Items.Clear();
                foreach (DataRow row in Globales.tablaSubCategorias.Rows)
                {
                    cbSubCategorias.Items.Add(row["descripcion"].ToString());
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeTabs()
        {
            TabCatalogs.TabPages.Remove(tabArticulos);
            TabCatalogs.TabPages.Remove(tabCategorias);
            TabCatalogs.TabPages.Remove(tabGrupos);
            TabCatalogs.TabPages.Remove(tabPaquetes);
            TabCatalogs.TabPages.Remove(tabCombinaciones);
            TabCatalogs.TabPages.Remove(tabSucursales);
            TabCatalogs.TabPages.Remove(tabProveedores);
            TabCatalogs.TabPages.Remove(tabClientes);
            TabCatalogs.TabPages.Remove(tabPagos);
            TabCatalogs.TabPages.Remove(tabMesas);  
        }

        #region Artículos

        private void BTBuscaArt_Click(object sender, EventArgs e)
        {
            cargaArticulos();
        }

        private void cargaArticulos()
        {
            try
            {
                //BTBuscaArt.Enabled = false;
                //LblArticulos.Text = "Loading...";
                //getArticulos(TxtArticulos.Text, CBEstatus.Text);
                Globales.tablaArticulos = new DataTable();
                Globales.tablaArticulos = articulosBL.getArticulos(TxtArticulos.Text, CBEstatus.Text, Globales.empresaId);
                GridArticulos.DataSource = Globales.tablaArticulos;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getArticulos(string descripcion, string estatus)
        {
            WSPOS.posservice service = new WSPOS.posservice();
            WSPOS.ArrayParameters arrayParameters = new WSPOS.ArrayParameters();
            WSPOS.ObjParameters objParameter = new WSPOS.ObjParameters();
            List<WSPOS.ObjParameters> listObjParameter = new List<WSPOS.ObjParameters>();
            WSPOS.Parameters Parameters = new WSPOS.Parameters();
            List<WSPOS.Parameters> listParameters = new List<WSPOS.Parameters>();

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

            objParameter.strProc = "sel_articulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            service.setTransactionsArrayCompleted +=
                new WSPOS.setTransactionsArrayCompletedEventHandler(service_setTransactionsArrayCompleted);

            service.setTransactionsArray(WSPOS.TransactionDb.SELECT, arrayParameters);
        }

        private void service_setTransactionsArrayCompleted(object sender, WSPOS.setTransactionsArrayCompletedEventArgs e)
        {
            GridArticulos.DataSource = e.Result;
            BTBuscaArt.Enabled = true;
            LblArticulos.Text = "";
        }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionArticulo edicionArticulo = new EdicionArticulo(Objetos.TipoTransaccion.INSERT);
                edicionArticulo.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridArticulos_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaArticulos)
            {
                seleccionaArticulo();
                EdicionArticulo edicionArticulo = new EdicionArticulo(Objetos.TipoTransaccion.UPDATE, articulos);
                edicionArticulo.ShowDialog();
                cargaArticulos();
            }
        }

        private void seleccionaArticulo()
        {
            try
            {
                articulos = new Articulos();
                int posicion_list = Convert.ToInt32(GridArticulos.CurrentRow.Index);
                articulos.id = GridArticulos.Rows[posicion_list].Cells[0].Value.ToString();
                articulos.ean = GridArticulos.Rows[posicion_list].Cells[1].Value.ToString();
                articulos.descripcion = GridArticulos.Rows[posicion_list].Cells[2].Value.ToString();
                articulos.medida = GridArticulos.Rows[posicion_list].Cells[3].Value.ToString();
                articulos.costo = GridArticulos.Rows[posicion_list].Cells[4].Value.ToString();
                articulos.venta = GridArticulos.Rows[posicion_list].Cells[5].Value.ToString();
                articulos.iva = GridArticulos.Rows[posicion_list].Cells[6].Value.ToString();
                articulos.estatus = GridArticulos.Rows[posicion_list].Cells[7].Value.ToString();
                articulos.unidad = GridArticulos.Rows[posicion_list].Cells[8].Value.ToString();
                articulos.grupo = GridArticulos.Rows[posicion_list].Cells[9].Value.ToString();
                articulos.subcategoria = GridArticulos.Rows[posicion_list].Cells[10].Value.ToString();
                articulos.distribuidor = GridArticulos.Rows[posicion_list].Cells[11].Value.ToString();
                articulos.principal = GridArticulos.Rows[posicion_list].Cells[12].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaArticulo();

                if (MessageBox.Show("Desea Eliminar el Artículo con ID: " + articulos.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(articulosBL.eliminaArticulo(articulos, Globales.empresaId));
                    cargaArticulos();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(articulosBL.genera_reporte(Globales.tablaArticulos));
        }

        private void BTArchivoTerminal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(articulosBL.genera_archivo_terminal(Globales.tablaArticulos));
        }

        private void BTCodigos_Click(object sender, EventArgs e)
        {
            GeneraCodigos generaCodigos = new GeneraCodigos();
            generaCodigos.ShowDialog();
        }

        private void BTArtProveedor_Click(object sender, EventArgs e)
        {
            EdicionArticulosProveedor artProveedor = new EdicionArticulosProveedor(Globales.tablaProveedores);
            artProveedor.ShowDialog();
        }

        private void btUnidades_Click(object sender, EventArgs e)
        {
            EdicionUnidades unidades = new EdicionUnidades();
            unidades.tablaUnidades = Globales.tablaUnidades;
            unidades.ShowDialog();
        }

        private void BTImpuestos_Click(object sender, EventArgs e)
        {
            EdicionImpuestos edicionImpuestos = new EdicionImpuestos();
            edicionImpuestos.tablaImpuestos = Globales.tablaImpuestos;
            edicionImpuestos.ShowDialog();
        }

        #endregion Artículos

        #region Categorias

        private void btBuscaCategorias_Click(object sender, EventArgs e)
        {
            cargaCategorias();
        }

        private void cargaCategorias()
        {
            try
            {
                DataTable table = categoriasBL.getCategorias(txtDescCategoria.Text.Trim(), Globales.empresaId);
                GridCategorias.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargaSubCategorias()
        {
            try
            {
                DataTable table = categoriasBL.getSubCategorias(categorias.id);
                GridSubCategorias.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridCategorias_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaCategorias)
            {
                seleccionaCategoria();
                EdicionCategoria edicionCategoria = new EdicionCategoria(Objetos.TipoTransaccion.UPDATE, categorias);
                edicionCategoria.ShowDialog();
                CatalogosTemp.getCategorias();
                cargaCategorias();
            }
        }

        private void seleccionaCategoria()
        {
            try
            {
                categorias = new Categorias();
                int posicion_list = Convert.ToInt32(GridCategorias.CurrentRow.Index);
                categorias.id = GridCategorias.Rows[posicion_list].Cells[0].Value.ToString();
                categorias.descripcion = GridCategorias.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevaCat_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionCategoria edicionCategoria = new EdicionCategoria(Objetos.TipoTransaccion.INSERT);
                edicionCategoria.ShowDialog();
                CatalogosTemp.getCategorias();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaCat_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaCategoria();

                if (MessageBox.Show("Desea Eliminar la Categoria con ID: " + categorias.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(categoriasBL.eliminaCategoria(categorias));
                    cargaCategorias();
                    CatalogosTemp.getCategorias();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridCategorias_Click(object sender, EventArgs e)
        {
            seleccionaCategoria();
            cargaSubCategorias();
        }

        private void BTNuevaSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionSubcategoria edicionSubcategoria = new EdicionSubcategoria(Objetos.TipoTransaccion.INSERT, categorias.id);
                edicionSubcategoria.ShowDialog();
                CatalogosTemp.getSubCategorias();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridSubCategorias_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaCategorias)
            {
                seleccionaSubCategoria();
                EdicionSubcategoria edicionSubcategoria = new EdicionSubcategoria(Objetos.TipoTransaccion.UPDATE, subCategorias);
                edicionSubcategoria.ShowDialog();
                cargaSubCategorias();
                CatalogosTemp.getSubCategorias();
            }
        }

        private void seleccionaSubCategoria()
        {
            try
            {
                subCategorias = new SubCategorias();
                int posicion_list = Convert.ToInt32(GridSubCategorias.CurrentRow.Index);
                subCategorias.categoriaID = categorias.id;
                subCategorias.id = GridSubCategorias.Rows[posicion_list].Cells[0].Value.ToString();
                subCategorias.descripcion = GridSubCategorias.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaSubCategoria();

                if (MessageBox.Show("Desea Eliminar la SubCategoria con ID: " + subCategorias.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(categoriasBL.eliminaSubCategoria(subCategorias));
                    cargaSubCategorias();
                    CatalogosTemp.getSubCategorias();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion SubCategorias

        #region Sucursales

        private void seleccionaSucursal()
        {
            try
            {
                sucursales = new Sucursales();
                int posicion_list = Convert.ToInt32(GridSucursales.CurrentRow.Index);
                sucursales.id = GridSucursales.Rows[posicion_list].Cells[0].Value.ToString();
                sucursales.nombre = GridSucursales.Rows[posicion_list].Cells[1].Value.ToString();
                sucursales.rfc = GridSucursales.Rows[posicion_list].Cells[2].Value.ToString();
                sucursales.razon_social = GridSucursales.Rows[posicion_list].Cells[3].Value.ToString();
                sucursales.codigo = GridSucursales.Rows[posicion_list].Cells[4].Value.ToString();
                sucursales.calle = GridSucursales.Rows[posicion_list].Cells[5].Value.ToString();
                sucursales.noInt = GridSucursales.Rows[posicion_list].Cells[6].Value.ToString();
                sucursales.noExt = GridSucursales.Rows[posicion_list].Cells[7].Value.ToString();
                sucursales.colonia = GridSucursales.Rows[posicion_list].Cells[8].Value.ToString();
                sucursales.cp = GridSucursales.Rows[posicion_list].Cells[9].Value.ToString();
                sucursales.municipioID = GridSucursales.Rows[posicion_list].Cells[10].Value.ToString();
                sucursales.estadoID = GridSucursales.Rows[posicion_list].Cells[11].Value.ToString();
                sucursales.telefono = GridSucursales.Rows[posicion_list].Cells[12].Value.ToString();
                sucursales.pie = GridSucursales.Rows[posicion_list].Cells[13].Value.ToString();
                sucursales.impuestoID = GridSucursales.Rows[posicion_list].Cells[14].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTBuscaSuc_Click(object sender, EventArgs e)
        {
            cargaSucursales();
        }

        private void cargaSucursales()
        {
            try
            {
                DataTable table = sucursalesBL.getSucursales(txtNombre.Text.Trim(), Globales.empresaId);
                GridSucursales.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevaSuc_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionSucursal edicionSucursal = new EdicionSucursal(Objetos.TipoTransaccion.INSERT);
                edicionSucursal.ShowDialog();
                CatalogosTemp.getSucursales();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaSuc_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaSucursal();

                if (MessageBox.Show("Desea Eliminar la Sucursal con ID: " + sucursales.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(sucursalesBL.eliminaSucursal(sucursales));
                    cargaSucursales();
                    CatalogosTemp.getSucursales();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridSucursales_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaSucursal)
            {
                seleccionaSucursal();
                EdicionSucursal edicionSucursal = new EdicionSucursal(Objetos.TipoTransaccion.UPDATE, sucursales);
                edicionSucursal.ShowDialog();
                cargaSucursales();
                CatalogosTemp.getSucursales();
            }
        }

        #endregion Sucursales

        #region Proveedores

        private void btBuscaProv_Click(object sender, EventArgs e)
        {
            cargaProveedores();
        }

        private void cargaProveedores()
        {
            try
            {
                DataTable table = proveedorBL.getProveedoresfiltro(txtRfcProv.Text, txtRazonProv.Text, Globales.empresaId);
                gridProveedor.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevoProv_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionProveedor edicionProveedor = new EdicionProveedor(Objetos.TipoTransaccion.INSERT);
                edicionProveedor.ShowDialog();
                CatalogosTemp.getProveedores();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridProveedor_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaProveedor)
            {
                seleccionaProveedor();
                EdicionProveedor edicionProveedor = new EdicionProveedor(Objetos.TipoTransaccion.UPDATE, proveedores);
                edicionProveedor.ShowDialog();
                cargaProveedores();
                CatalogosTemp.getProveedores();
            }
        }

        private void seleccionaProveedor()
        {
            try
            {
                proveedores = new Proveedores();
                int posicion_list = Convert.ToInt32(gridProveedor.CurrentRow.Index);
                proveedores.id = gridProveedor.Rows[posicion_list].Cells[0].Value.ToString();
                proveedores.rfc = gridProveedor.Rows[posicion_list].Cells[1].Value.ToString();
                proveedores.razon = gridProveedor.Rows[posicion_list].Cells[2].Value.ToString();
                proveedores.alias = gridProveedor.Rows[posicion_list].Cells[3].Value.ToString();
                proveedores.direccion = gridProveedor.Rows[posicion_list].Cells[4].Value.ToString();
                proveedores.almacen = Convert.ToBoolean(gridProveedor.Rows[posicion_list].Cells[5].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaProv_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaProveedor();

                if (MessageBox.Show("Desea Eliminar el Proveedor con ID: " + proveedores.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(proveedorBL.eliminaProveedor(proveedores));
                    cargaProveedores();
                    CatalogosTemp.getProveedores();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Proveedores

        #region Paquetes

        private void BTBuscarPaquete_Click(object sender, EventArgs e)
        {
            cargaPaquetes();
        }

        private void cargaPaquetes()
        {
            try
            {
                DataTable table = paquetesBL.getPaquetes(txtPaquetes.Text.Trim(), Globales.empresaId);
                GridPaquetes.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevoPaquete_Click(object sender, EventArgs e)
        {
            EdicionPaquetes edicionPaquetes = new EdicionPaquetes(Objetos.TipoTransaccion.INSERT);
            edicionPaquetes.ShowDialog();
        }

        private void GridPaquetes_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaPaquetes)
            {
                seleccionaPaquete();
                EdicionPaquetes edicionPaquetes = new EdicionPaquetes(paquetes, Objetos.TipoTransaccion.UPDATE);
                edicionPaquetes.ShowDialog();
                cargaPaquetes();
            }
        }

        private void seleccionaPaquete()
        {
            try
            {
                paquetes = new Paquetes();
                int posicion_list = Convert.ToInt32(GridPaquetes.CurrentRow.Index);
                paquetes.id = GridPaquetes.Rows[posicion_list].Cells[0].Value.ToString();
                paquetes.descripcion = GridPaquetes.Rows[posicion_list].Cells[1].Value.ToString();
                paquetes.categoria = GridPaquetes.Rows[posicion_list].Cells[2].Value.ToString();
                paquetes.precioVenta = GridPaquetes.Rows[posicion_list].Cells[3].Value.ToString();
                paquetes.noArticulos = GridPaquetes.Rows[posicion_list].Cells[4].Value.ToString();
                paquetes.estatus = GridPaquetes.Rows[posicion_list].Cells[5].Value.ToString();
                paquetes.horaInicio = GridPaquetes.Rows[posicion_list].Cells[6].Value.ToString();
                paquetes.horaFin = GridPaquetes.Rows[posicion_list].Cells[7].Value.ToString();
                paquetes.consumo = GridPaquetes.Rows[posicion_list].Cells[8].Value.ToString();
                paquetes.sucursal = GridPaquetes.Rows[posicion_list].Cells[9].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaPaquetes_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaPaquete();

                if (MessageBox.Show("Desea Eliminar el Paquete con ID: " + paquetes.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(paquetesBL.eliminaPaquete(paquetes.id));
                    cargaPaquetes();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Paquetes

        #region Combinaciones

        private void btNuevaCombinacion_Click(object sender, EventArgs e)
        {
            EdicionCombinaciones edicionCombinaciones = new EdicionCombinaciones(Objetos.TipoTransaccion.INSERT);
            edicionCombinaciones.ShowDialog();
        }

        private void btBuscaCombinacion_Click(object sender, EventArgs e)
        {
            cargaCombinaciones();
        }

        private void cargaCombinaciones()
        {
            try
            {
                DataTable table = paquetesBL.getCombinaciones(txtCombinacion.Text.Trim(), Globales.empresaId);
                GridCombinaciones.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridCombinaciones_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaCombinaciones)
            {
                seleccionaCombinacion();
                EdicionCombinaciones edicionCombinaciones = new EdicionCombinaciones(combinaciones, Objetos.TipoTransaccion.UPDATE);
                edicionCombinaciones.ShowDialog();
                cargaCombinaciones();
            }
        }

        private void seleccionaCombinacion()
        {
            try
            {
                combinaciones = new Combinaciones();
                int posicion_list = Convert.ToInt32(GridCombinaciones.CurrentRow.Index);
                combinaciones.id = GridCombinaciones.Rows[posicion_list].Cells[0].Value.ToString();
                combinaciones.descripcion = GridCombinaciones.Rows[posicion_list].Cells[1].Value.ToString();
                combinaciones.precioVenta = GridCombinaciones.Rows[posicion_list].Cells[2].Value.ToString();
                combinaciones.estatus = GridCombinaciones.Rows[posicion_list].Cells[3].Value.ToString();
                combinaciones.categoria = GridCombinaciones.Rows[posicion_list].Cells[4].Value.ToString();
                combinaciones.horaInicio = GridCombinaciones.Rows[posicion_list].Cells[5].Value.ToString();
                combinaciones.horaFin = GridCombinaciones.Rows[posicion_list].Cells[6].Value.ToString();
                combinaciones.consumo = GridCombinaciones.Rows[posicion_list].Cells[7].Value.ToString();
                combinaciones.sucursal = GridCombinaciones.Rows[posicion_list].Cells[8].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminarCombinacion_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaCombinacion();

                if (MessageBox.Show("Desea Eliminar la Combinacion con ID: " + combinaciones.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(paquetesBL.eliminaCombinacion(combinaciones.id));
                    cargaCombinaciones();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Combinaciones

        #region Mesas

        private void btBuscarMesa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSucursalesMesas.Text.Trim()))
                MessageBox.Show("Favor de seleccionar una Sucursal");
            else
                cargaMesas();
        }

        private void cargaMesas()
        {
            try
            {
                DataRow[] foundRows;
                foundRows = tableSucursales.Select("nombre = '" + cbSucursalesMesas.Text.Trim() + "'");

                DataTable table = mesasBL.getMesas("", foundRows[0].ItemArray[0].ToString());
                GridMesas.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevaMesa_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionMesa edicionMesa = new EdicionMesa(Objetos.TipoTransaccion.INSERT);
                edicionMesa.tableSucursales = tableSucursales;
                edicionMesa.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaMesa_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaMesa();

                if (MessageBox.Show("Desea Eliminar la Mesa con ID: " + mesas.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(mesasBL.eliminaMesa(mesas));
                    cargaMesas();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridMesas_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaMesa)
            {
                seleccionaMesa();
                EdicionMesa edicionMesa = new EdicionMesa(mesas, Objetos.TipoTransaccion.UPDATE);
                edicionMesa.tableSucursales = tableSucursales;
                edicionMesa.ShowDialog();
                cargaMesas();
            }
        }

        private void seleccionaMesa()
        {
            try
            {
                mesas = new Mesas();
                int posicion_list = Convert.ToInt32(GridMesas.CurrentRow.Index);
                mesas.id = GridMesas.Rows[posicion_list].Cells[0].Value.ToString();
                mesas.nombre = GridMesas.Rows[posicion_list].Cells[1].Value.ToString();
                mesas.numero = GridMesas.Rows[posicion_list].Cells[2].Value.ToString();
                mesas.sucursalID = cbSucursalesMesas.Text.Trim();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Mesas

        #region Grupos

        private void btBuscaGrupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSubCategorias.Text.Trim()))
                MessageBox.Show("Favor de seleccionar una subcategoria");
            else
                cargaGrupos();
        }

        private void cargaGrupos()
        {
            try
            {
                DataRow[] foundRows;
                foundRows = Globales.tablaSubCategorias.Select("descripcion = '" + cbSubCategorias.Text.Trim() + "'");

                DataTable table = categoriasBL.getGrupos(foundRows[0].ItemArray[0].ToString());
                GridGrupos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevoGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionGrupo edicionGrupo = new EdicionGrupo(Objetos.TipoTransaccion.INSERT);
                edicionGrupo.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridGrupos_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaGrupos)
            {
                seleccionaGrupos();
                EdicionGrupo edicionGrupo = new EdicionGrupo(Objetos.TipoTransaccion.UPDATE, grupos);
                edicionGrupo.ShowDialog();
                cargaGrupos();
            }
        }

        private void seleccionaGrupos()
        {
            try
            {
                grupos = new Grupos();
                int posicion_list = Convert.ToInt32(GridGrupos.CurrentRow.Index);
                grupos.grupoID = GridGrupos.Rows[posicion_list].Cells[0].Value.ToString();
                grupos.descripcion = GridGrupos.Rows[posicion_list].Cells[1].Value.ToString();

                DataRow[] foundRows;
                foundRows = Globales.tablaSubCategorias.Select("descripcion = '" + cbSubCategorias.Text.Trim() + "'");
                grupos.subcategoriaId = foundRows[0].ItemArray[0].ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaGrupos();

                if (MessageBox.Show("Desea Eliminar el Grupo con ID: " + grupos.grupoID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(categoriasBL.eliminaGrupo(grupos));
                    cargaGrupos();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Grupos

        #region Clientes

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            cargaClientes();
        }

        private void cargaClientes()
        {
            try
            {
                DataTable table = clientesBL.getClientesfiltro(txtRazonCliente.Text.Trim(), txtRazonCliente.Text.Trim(), Globales.empresaId);
                GridClientes.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionCliente edicionCliente = new EdicionCliente(Objetos.TipoTransaccion.INSERT);
                edicionCliente.ShowDialog();
                //CatalogosTemp.getProveedores();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridClientes_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaClientes)
            {
                seleccionaCliente();
                EdicionCliente edicionCliente = new EdicionCliente(Objetos.TipoTransaccion.UPDATE, clientes);
                edicionCliente.ShowDialog();
                cargaClientes();
                //CatalogosTemp.getProveedores();
            }
        }

        private void seleccionaCliente()
        {
            try
            {
                clientes = new Clientes();
                int posicion_list = Convert.ToInt32(GridClientes.CurrentRow.Index);
                clientes.id = GridClientes.Rows[posicion_list].Cells[0].Value.ToString();
                clientes.rfc = GridClientes.Rows[posicion_list].Cells[1].Value.ToString();
                clientes.nombreComercial = GridClientes.Rows[posicion_list].Cells[2].Value.ToString();
                clientes.razonSocial = GridClientes.Rows[posicion_list].Cells[3].Value.ToString();
                clientes.calle = GridClientes.Rows[posicion_list].Cells[4].Value.ToString();
                clientes.noExt = GridClientes.Rows[posicion_list].Cells[5].Value.ToString();
                clientes.noInt = GridClientes.Rows[posicion_list].Cells[6].Value.ToString();
                clientes.colonia = GridClientes.Rows[posicion_list].Cells[7].Value.ToString();
                clientes.cp = GridClientes.Rows[posicion_list].Cells[8].Value.ToString();
                clientes.municipioID = GridClientes.Rows[posicion_list].Cells[9].Value.ToString();
                clientes.estadoID = GridClientes.Rows[posicion_list].Cells[10].Value.ToString();
                clientes.distribuidor = GridClientes.Rows[posicion_list].Cells[11].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaCliente();

                if (MessageBox.Show("Desea Eliminar el Cliente con ID: " + clientes.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(clientesBL.eliminaCliente(clientes));
                    cargaClientes();
                    ///CatalogosTemp.getProveedores();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Clientes

        #region Pagos

        private void gridPagos_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaFormasPago)
            {
                seleccionaFormaPago();
                EdicionFormaPago edicionFormaPago = new EdicionFormaPago(Objetos.TipoTransaccion.UPDATE, formasPago);
                edicionFormaPago.ShowDialog();
                cargaPagos();
                CatalogosTemp.getFormasPago();
            }
        }

        private void seleccionaFormaPago()
        {
            try
            {
                formasPago = new FormasPago();
                int posicion_list = Convert.ToInt32(gridPagos.CurrentRow.Index);
                formasPago.id = gridPagos.Rows[posicion_list].Cells[0].Value.ToString();
                formasPago.descripcion = gridPagos.Rows[posicion_list].Cells[1].Value.ToString();
                formasPago.estatus = gridPagos.Rows[posicion_list].Cells[2].Value.ToString();
                formasPago.credito = Convert.ToBoolean(gridPagos.Rows[posicion_list].Cells[3].Value);
                formasPago.principal = Convert.ToInt32(gridPagos.Rows[posicion_list].Cells[4].Value);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBuscaPago_Click(object sender, EventArgs e)
        {
            cargaPagos();
        }

        private void cargaPagos()
        {
            try
            {
                DataTable table = formasPagoBL.getPagos(txtPagos.Text, Globales.empresaId);
                gridPagos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevoPago_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionFormaPago edicionFormaPago = new EdicionFormaPago(Objetos.TipoTransaccion.INSERT);
                edicionFormaPago.ShowDialog();
                CatalogosTemp.getFormasPago();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaPago_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaFormaPago();

                if (MessageBox.Show("Desea Eliminar la Forma de Pago con ID: " + formasPago.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(formasPagoBL.eliminaProveedor(formasPago));
                    cargaPagos();
                    CatalogosTemp.getFormasPago();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Pagos

    }
}
