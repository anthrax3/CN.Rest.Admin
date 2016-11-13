using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;
using POS.Admin.Identities;
using POS.Security;
using System.IO;

using System.Diagnostics;namespace POS.Admin.Appl
{
    public partial class MainForm : Form
    {
        #region Variables

        private ArticulosBL articulosBL;
        private List<String> estatus = new List<String>();
        private Articulos articulos = new Articulos();
        private DataTable tablaArticulos;

        private SucursalesBL sucursalesBL;
        private Sucursales sucursales;

        private Ordenes ordenes;
        private OrdenesBL ordenesBL;

        private ProveedorBL proveedorBL;
        private Proveedores proveedores;

        private DataTable tablaSucursales;
        private DataTable tablaProveedores;

        private Entradas entradas;
        private EntradasBL entradasBL;

        private InventariosBL inventariosBL;
        private DataTable tablaInventarios;

        private DevolucionOrden devolucionOrden;
        private DevolucionOrdenBL devolucionOrdenBL;

        private SeguridadBL seguridadBL;
        private DataTable tablaRoles = new DataTable();

        private InvSucursalBL invSucursalBL;
        private DataTable tablaInvSucursal;

        private int usuarioID;
        private int rolID;
        private int politicaID;
        private int moduloID;
        private string rol;
        private string modulo; 

        //Modificar grids
        private bool modificaOrden = false;
        private bool modificaEntrada = false;
        private bool modificaSucursal = false;
        private bool modificaProveedor = false;
        private bool modificaDevolucion = false;
        private bool modificaArticulos = false;

        private RespaldosBL respaldosBL;

        #endregion Variables

        #region Principal

        public MainForm()
        {
            InitializeComponent();

            /*try
            {
                Security.Cryptography.CreateKeys();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(String.Format("We are sorry but this quick start is unable to run. It requires a key file " + 
                    "to be created to be used for symmetric cryptographic operations, and we can't create this file. " +
                    "The most common reason for this is that the quick starts were not installed into their default " + 
                    "installation location. If this is true, please edit the configuration file to reflect the installation path. " +
                    "The exception message is: {0}", ioe.Message),
                    "Unable to write key file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void tbConnect_Click(object sender, EventArgs e)
        {
            try
            {
                seguridadBL = new SeguridadBL();

                Acceso acceso = new Acceso(seguridadBL);
                acceso.ShowDialog();

                if (acceso.status)
                {
                    articulosBL = new ArticulosBL();
                    estatus = articulosBL.getEstatus();
                    CBEstatus.Items.Clear();
                    CBEstatus.Items.AddRange(estatus.ToArray());
                    sucursalesBL = new SucursalesBL();
                    sucursales = new Sucursales();
                    ordenesBL = new OrdenesBL();
                    ordenes = new Ordenes();
                    proveedorBL = new ProveedorBL();
                    proveedores = new Proveedores();
                    entradasBL = new EntradasBL();
                    entradas = new Entradas();
                    inventariosBL = new InventariosBL();
                    devolucionOrden = new DevolucionOrden();
                    devolucionOrdenBL = new DevolucionOrdenBL();
                    invSucursalBL = new InvSucursalBL();
                    respaldosBL = new RespaldosBL();

                    getProveedores();
                    getSucursales();

                    MessageBox.Show("El sistema esta conectado al Servidor Remoto", "Conexión Satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    aplicaPoliticas(acceso.tablaAccesos);
                    acceso.Dispose();

                    tbDisconnect.Enabled = true;
                    tbActiveSync.Enabled = true;
                }
                else
                    seguridadBL = null;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error al Conectar con Servidor Remoto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDisconnect_Click(object sender, EventArgs e)
        { 
            try
            {
                seguridadBL = null;
                articulosBL = null;
                sucursalesBL = null;
                sucursales = null;
                ordenesBL = null;
                ordenes = null;
                proveedorBL = null;
                proveedores = null;
                entradasBL = null;
                entradas = null;
                inventariosBL = null;
                devolucionOrden = null;
                devolucionOrdenBL = null;
                invSucursalBL = null;
                respaldosBL = null;

                CBEstatus.Items.Clear();
                cbProveedorInv.Items.Clear();
                cbSucursalInv.Items.Clear();
                cbRespaldos.Items.Clear();

                tbDisconnect.Enabled = false;
                tbActiveSync.Enabled = false;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error al Desconectar con Servidor Remoto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbActiveSync_Click(object sender, EventArgs e)
        {
            string version = GenericBL.mostrarVersion();
            string[] control = version.Split('.');

            if (control[0].Equals("5") && control[1].Equals("1"))
                Process.Start(@"C:\Archivos de programa\Microsoft ActiveSync\WCESMgr.exe");
            else if (control[0].Equals("6"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = true;
                startInfo.FileName = @"C:\Windows\WindowsMobile\wmdc.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = "/show";
                Process hbProc = new Process();
                hbProc = Process.Start(startInfo);
                hbProc.WaitForExit();
            }
        }

        private void aplicaPoliticas(DataTable tablaAccesos)
        {
            foreach (DataRow row in tablaAccesos.Rows)
            {
                switch (row["modulo"].ToString())
                {
                    case "ARTICULOS":
                        BTNuevo.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaArticulos = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminar.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaArt.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "SUCURSALES":
                        BTNuevaSuc.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaSucursal = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaSuc.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaSuc.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "PROVEEDORES":
                        btNuevoProv.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaProveedor = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaProv.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaProv.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "ORDENES":
                        BTNuevaOrden.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaOrden = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaOrden.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaOrden.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "DEVOLUCIONES":
                        btNuevaDev.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaDevolucion= (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaDev.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaDev.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "INVENTARIOS":
                        btBuscaInv.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "ENTRADAS":
                        BTNuevaEntrada.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        modificaEntrada = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaEntrada.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaEntrada.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "MOVIMIENTOS":
                        gbMovimientos.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "SEGURIDAD":
                        if (Convert.ToBoolean(row["agregar"]))
                        {
                            BTNuevoRol.Enabled = true;
                            BTNuevoUsuario.Enabled = true;
                            BTAsignaPolitica.Enabled = true;
                        }
                        else
                        {
                            BTNuevoRol.Enabled = false;
                            BTNuevoUsuario.Enabled = false;
                            BTAsignaPolitica.Enabled = false;
                        }
                        if (Convert.ToBoolean(row["eliminar"]))
                        {
                            BTEliminaRol.Enabled = true;
                            BTEliminaUsuario.Enabled = true;
                            BTEliminaPolitica.Enabled = true;
                        }
                        else
                        {
                            BTEliminaRol.Enabled = false;
                            BTEliminaUsuario.Enabled = false;
                            BTEliminaPolitica.Enabled = false;
                        }
                        if (Convert.ToBoolean(row["visualizar"]))
                        {
                            BTCargaRol.Enabled = true;
                            BTCargaUsuario.Enabled = true;
                            BTCargaModulo.Enabled = true;
                            BTCargarPolitica.Enabled = true;
                        }
                        else
                        {
                            BTCargaRol.Enabled = false;
                            BTCargaUsuario.Enabled = false;
                            BTCargaModulo.Enabled = false;
                            BTCargarPolitica.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void getProveedores()
        {
            tablaProveedores = new DataTable();
            tablaProveedores = proveedorBL.getProveedores();

            cbProveedorInv.Items.Clear();
            foreach (DataRow row in tablaProveedores.Rows)
            {
                if (row["almacen"].Equals(true))
                    cbProveedorInv.Items.Add(row["descripcion"]);
            }
        }

        private void getSucursales()
        {
            tablaSucursales = new DataTable();
            tablaSucursales = sucursalesBL.getSucursales("");

            cbSucursalInv.Items.Clear();
            cbRespaldos.Items.Clear();
            foreach (DataRow row in tablaSucursales.Rows)
            {
                cbSucursalInv.Items.Add(row["nombre"]);
                cbRespaldos.Items.Add(row["nombre"]);
            }
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 2;
            reportes.ShowDialog();
        }

        private void btReporteDev_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 4;
            reportes.ShowDialog();
        }

        #endregion Principal

        #region Artículos

        private void BTBuscaArt_Click(object sender, EventArgs e)
        {
            cargaArticulos();
        }

        private void cargaArticulos()
        {
            try
            {
                /*BTBuscaArt.Enabled = false;
                LblArticulos.Text = "Loading...";
                getArticulos(TxtArticulos.Text, CBEstatus.Text);*/
                tablaArticulos = new DataTable();
                tablaArticulos = articulosBL.getArticulos(TxtArticulos.Text, CBEstatus.Text);
                GridArticulos.DataSource = tablaArticulos;
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

            objParameter.strProc = "pv_server.sel_articulos";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            service.setTransactionsArrayCompleted +=
                new WSPOS.setTransactionsArrayCompletedEventHandler(service_setTransactionsArrayCompleted);

            service.setTransactionsArrayAsync(WSPOS.TransactionDb.SELECT, arrayParameters);
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
                EdicionArticulo edicionArticulo = new EdicionArticulo(estatus, Objetos.TipoTransaccion.INSERT);
                edicionArticulo.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridArticulos_DoubleClick(object sender, EventArgs e)
        {
            if (modificaArticulos)
            {
                seleccionaArticulo();
                EdicionArticulo edicionArticulo = new EdicionArticulo(estatus, Objetos.TipoTransaccion.UPDATE, articulos);
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
                articulos.venta = GridArticulos.Rows[posicion_list].Cells[3].Value.ToString();
                articulos.costo = GridArticulos.Rows[posicion_list].Cells[4].Value.ToString();
                articulos.iva = GridArticulos.Rows[posicion_list].Cells[5].Value.ToString();
                articulos.estatus = GridArticulos.Rows[posicion_list].Cells[6].Value.ToString();
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
                    MessageBox.Show(articulosBL.eliminaArticulo(articulos));
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
            MessageBox.Show(articulosBL.genera_reporte(tablaArticulos));
        }

        private void BTArchivoTerminal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(articulosBL.genera_archivo_terminal(tablaArticulos));
        }

        private void BTCodigos_Click(object sender, EventArgs e)
        {
            GeneraCodigos generaCodigos = new GeneraCodigos();
            generaCodigos.ShowDialog();
        }

        private void BTLigaProveedor_Click(object sender, EventArgs e)
        {
            EdicionArticulosProveedor artProveedor = new EdicionArticulosProveedor();
            artProveedor.ShowDialog();
        }

        #endregion Artículos

        #region Sucursales

        private void seleccionaSucursal()
        {
            try
            {
                sucursales = new Sucursales();
                int posicion_list = Convert.ToInt32(GridSucursales.CurrentRow.Index);
                sucursales.id = GridSucursales.Rows[posicion_list].Cells[0].Value.ToString();
                sucursales.nombre = GridSucursales.Rows[posicion_list].Cells[1].Value.ToString();
                sucursales.codigo = GridSucursales.Rows[posicion_list].Cells[2].Value.ToString();
                sucursales.pc = GridSucursales.Rows[posicion_list].Cells[3].Value.ToString();
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
                DataTable table = sucursalesBL.getSucursales(txtNombre.Text.Trim());
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
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridSucursales_DoubleClick(object sender, EventArgs e)
        {
            if (modificaSucursal)
            {
                seleccionaSucursal();
                EdicionSucursal edicionSucursal = new EdicionSucursal(Objetos.TipoTransaccion.UPDATE, sucursales);
                edicionSucursal.ShowDialog();
                cargaSucursales();
            }
        }

        #endregion Sucursales

        #region Ordenes

        private void GridOrdenes_DoubleClick(object sender, EventArgs e)
        {
            if (modificaOrden)
            {
                seleccionaOrden();
                EdicionOrden edicionOrden = new EdicionOrden(Objetos.TipoTransaccion.UPDATE, ordenes, tablaProveedores, tablaSucursales);
                edicionOrden.ShowDialog();
                cargaOrdenes();
            }
        }

        private void seleccionaOrden()
        {
            try
            {
                ordenes = new Ordenes();
                int posicion_list = Convert.ToInt32(GridOrdenes.CurrentRow.Index);
                ordenes.id = GridOrdenes.Rows[posicion_list].Cells[0].Value.ToString();
                ordenes.sucursalID = GridOrdenes.Rows[posicion_list].Cells[1].Value.ToString();
                ordenes.proveedorID = GridOrdenes.Rows[posicion_list].Cells[2].Value.ToString();
                ordenes.noOrden = GridOrdenes.Rows[posicion_list].Cells[3].Value.ToString();
                ordenes.factura = GridOrdenes.Rows[posicion_list].Cells[4].Value.ToString();
                ordenes.subtotal = GridOrdenes.Rows[posicion_list].Cells[5].Value.ToString();
                ordenes.total_iva = GridOrdenes.Rows[posicion_list].Cells[6].Value.ToString();
                ordenes.grantotal = GridOrdenes.Rows[posicion_list].Cells[7].Value.ToString();
                ordenes.estatus = GridOrdenes.Rows[posicion_list].Cells[8].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTBuscaOrden_Click(object sender, EventArgs e)
        {
            cargaOrdenes();
        }

        private void cargaOrdenes()
        {
            try
            {
                /*BTBuscaOrden.Enabled = false;
                lblOrdenes.Text = "Loading...";
                getOrdenes(txtFactura.Text, txtOrden.Text);*/
                DataTable table = ordenesBL.getOrdenes(txtFactura.Text, txtOrden.Text);
                GridOrdenes.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getOrdenes(string factura, string orden)
        {
            WSPOS.posservice service = new WSPOS.posservice();
            WSPOS.ArrayParameters arrayParameters = new WSPOS.ArrayParameters();
            WSPOS.ObjParameters objParameter = new WSPOS.ObjParameters();
            List<WSPOS.ObjParameters> listObjParameter = new List<WSPOS.ObjParameters>();
            WSPOS.Parameters Parameters = new WSPOS.Parameters();
            List<WSPOS.Parameters> listParameters = new List<WSPOS.Parameters>();

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

            objParameter.strProc = "pv_server.sel_ordenes";
            objParameter.ListParameters = listParameters.ToArray();
            listObjParameter.Add(objParameter);

            arrayParameters.objParameters = listObjParameter.ToArray();

            service.setTransactionsArrayCompleted +=
                new WSPOS.setTransactionsArrayCompletedEventHandler(service_setOrdersCompleted);

            service.setTransactionsArrayAsync(WSPOS.TransactionDb.SELECT, arrayParameters);
        }

        private void service_setOrdersCompleted(object sender, WSPOS.setTransactionsArrayCompletedEventArgs e)
        {
            GridOrdenes.DataSource = e.Result;
            BTBuscaOrden.Enabled = true;
            lblOrdenes.Text = "";
        }

        private void BTNuevaOrden_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionOrden edicionOrden = new EdicionOrden(Objetos.TipoTransaccion.INSERT, tablaProveedores, tablaSucursales);
                edicionOrden.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaOrden_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaOrden();

                if (MessageBox.Show("Desea Eliminar la Orden con ID: " + ordenes.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(ordenesBL.eliminaOrden(ordenes));
                    cargaOrdenes();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTOrdenTerminal_Click(object sender, EventArgs e)
        {
            OrdenesTerminal ordenesTerminal = new OrdenesTerminal();
            ordenesTerminal.ShowDialog();
        }

        #endregion Ordenes

        #region Proveedores

        private void btBuscaProv_Click(object sender, EventArgs e)
        {
            cargaProveedores();
        }

        private void cargaProveedores()
        {
            try
            {
                DataTable table = proveedorBL.getProveedoresfiltro(txtRfcProv.Text, txtRazonProv.Text);
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
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridProveedor_DoubleClick(object sender, EventArgs e)
        {
            if (modificaProveedor)
            {
                seleccionaProveedor();
                EdicionProveedor edicionProveedor = new EdicionProveedor(Objetos.TipoTransaccion.UPDATE, proveedores);
                edicionProveedor.ShowDialog();
                cargaProveedores();
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
                proveedores.direccion = gridProveedor.Rows[posicion_list].Cells[3].Value.ToString();
                proveedores.almacen = Convert.ToBoolean(gridProveedor.Rows[posicion_list].Cells[4].Value.ToString());
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
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Proveedores

        #region Entradas

        private void BTBuscaEntrada_Click(object sender, EventArgs e)
        {
            cargaEntradas();
        }

        private void cargaEntradas()
        {
            try
            {
                DataTable table = entradasBL.getEntradas(txtFacturaAlmacen.Text, txtFolioAlmacen.Text);
                gridEntradas.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevaEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionEntrada EdicionEntrada = new EdicionEntrada(Objetos.TipoTransaccion.INSERT, tablaProveedores);
                EdicionEntrada.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridEntradas_DoubleClick(object sender, EventArgs e)
        {
            if (modificaEntrada)
            {
                seleccionaEntrada();
                EdicionEntrada edicionEntrada = new EdicionEntrada(Objetos.TipoTransaccion.UPDATE, entradas, tablaProveedores);
                edicionEntrada.ShowDialog();
                cargaEntradas();
            }
        }

        private void seleccionaEntrada()
        {
            try
            {
                entradas = new Entradas();
                int posicion_list = Convert.ToInt32(gridEntradas.CurrentRow.Index);
                entradas.entradaID = gridEntradas.Rows[posicion_list].Cells[0].Value.ToString();
                entradas.proveedorID = gridEntradas.Rows[posicion_list].Cells[1].Value.ToString();
                entradas.proveedor_compraID = gridEntradas.Rows[posicion_list].Cells[2].Value.ToString();
                entradas.fecha_entrada = gridEntradas.Rows[posicion_list].Cells[3].Value.ToString();
                entradas.fecha_generacion = gridEntradas.Rows[posicion_list].Cells[4].Value.ToString();
                entradas.estatus = gridEntradas.Rows[posicion_list].Cells[5].Value.ToString();
                entradas.factura = gridEntradas.Rows[posicion_list].Cells[6].Value.ToString();
                entradas.folio = gridEntradas.Rows[posicion_list].Cells[7].Value.ToString();
                entradas.importeCero = gridEntradas.Rows[posicion_list].Cells[8].Value.ToString();
                entradas.importeQuince = gridEntradas.Rows[posicion_list].Cells[9].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaEntrada();

                if (MessageBox.Show("Desea Eliminar la Entrada con ID: " + entradas.entradaID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(entradasBL.eliminaEntrada(entradas.entradaID));
                    cargaEntradas();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Entradas

        #region Inventarios

        private void btBuscaInv_Click(object sender, EventArgs e)
        {
            cargaInventarios();
        }

        private void cargaInventarios()
        {
            string proveedorID = string.Empty;

            try
            {
                foreach (DataRow row in tablaProveedores.Rows)
                {
                    if (row["descripcion"].Equals(cbProveedorInv.Text.Trim()))
                    {
                        proveedorID = row["proveedorID"].ToString();
                        break;
                    }
                }

                tablaInventarios = new DataTable();
                tablaInventarios = inventariosBL.getInventarios(proveedorID, txtDescripcionInv.Text);
                gridInventarios.DataSource = tablaInventarios;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExportarInv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inventariosBL.genera_reporte(tablaInventarios));
        }

        #endregion Inventarios

        #region Devolucion Orden

        private void btBuscaDev_Click(object sender, EventArgs e)
        {
            cargaDevolucionOrdenes();
        }

        private void cargaDevolucionOrdenes()
        {
            try
            {
                DataTable table = devolucionOrdenBL.getDevolucionOrden(txtNoDevolucion.Text);
                gridDevoluciones.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevaDev_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionDevolucionOrden edicionDevOrden = new EdicionDevolucionOrden(Objetos.TipoTransaccion.INSERT, tablaProveedores, tablaSucursales);
                edicionDevOrden.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDevoluciones_DoubleClick(object sender, EventArgs e)
        {
            if (modificaDevolucion)
            {
                seleccionaDevOrden();
                EdicionDevolucionOrden edicionDevOrden = new EdicionDevolucionOrden(Objetos.TipoTransaccion.UPDATE, devolucionOrden, tablaProveedores, tablaSucursales);
                edicionDevOrden.ShowDialog();
                cargaDevolucionOrdenes();
            }
        }

        private void seleccionaDevOrden()
        {
            try
            {
                devolucionOrden = new DevolucionOrden();
                int posicion_list = Convert.ToInt32(gridDevoluciones.CurrentRow.Index);
                devolucionOrden.id = gridDevoluciones.Rows[posicion_list].Cells[0].Value.ToString();
                devolucionOrden.sucursalID = gridDevoluciones.Rows[posicion_list].Cells[1].Value.ToString();
                devolucionOrden.proveedorID = gridDevoluciones.Rows[posicion_list].Cells[2].Value.ToString();
                devolucionOrden.noOrden = gridDevoluciones.Rows[posicion_list].Cells[3].Value.ToString();
                devolucionOrden.subtotal = gridDevoluciones.Rows[posicion_list].Cells[4].Value.ToString();
                devolucionOrden.total_iva = gridDevoluciones.Rows[posicion_list].Cells[5].Value.ToString();
                devolucionOrden.grantotal = gridDevoluciones.Rows[posicion_list].Cells[6].Value.ToString();
                devolucionOrden.estatus = gridDevoluciones.Rows[posicion_list].Cells[7].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaDev_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaDevOrden();

                if (MessageBox.Show("Desea Eliminar la Devolución de Orden con ID: " + devolucionOrden.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(devolucionOrdenBL.eliminaDevolucionOrden(devolucionOrden));
                    cargaDevolucionOrdenes();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Devolucion Orden  

        #region Seguridad

        private void BTCargaRol_Click(object sender, EventArgs e)
        {
            cargaRoles();
        }

        private void cargaRoles()
        {
            try
            {
                tablaRoles = seguridadBL.getRoles();
                gridRoles.DataSource = tablaRoles;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaRol_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaRol();

                if (MessageBox.Show("Desea Eliminar el Rol con ID: " + rolID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaRol(rolID));
                    cargaRoles();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaRol()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridRoles.CurrentRow.Index);
                rolID = int.Parse(gridRoles.Rows[posicion_list].Cells[0].Value.ToString());
                rol = gridRoles.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevoRol_Click(object sender, EventArgs e)
        {
            EdicionRol edicionRol = new EdicionRol(seguridadBL);
            edicionRol.ShowDialog();
            cargaRoles();
        }

        private void BTCargaUsuario_Click(object sender, EventArgs e)
        {
            cargaUsuarios();
        }

        private void cargaUsuarios()
        {
            try
            {
                DataTable table = seguridadBL.getUsuarios();
                gridUsuarios.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaUsuario();

                if (MessageBox.Show("Desea Eliminar al Usuario con ID: " + usuarioID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaUsuario(usuarioID));
                    cargaUsuarios();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaUsuario()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridUsuarios.CurrentRow.Index);
                usuarioID = int.Parse(gridUsuarios.Rows[posicion_list].Cells[0].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTCargaModulo_Click(object sender, EventArgs e)
        {
            cargaModulos();
        }

        private void BTNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (tablaRoles.Rows.Count <= 0)
                tablaRoles = seguridadBL.getRoles();
            EdicionUsuario edicionUsuario = new EdicionUsuario(seguridadBL, tablaRoles);
            edicionUsuario.ShowDialog();
            cargaUsuarios();
        }

        private void cargaModulos()
        {
            try
            {
                DataTable table = seguridadBL.getModulos();
                gridModulos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTCargarPolitica_Click(object sender, EventArgs e)
        {
            cargaPoliticas();
        }

        private void cargaPoliticas()
        {
            try
            {
                seleccionaRol();
                DataTable table = seguridadBL.getPoliticas(rolID);
                gridPoliticas.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaPolitica_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaPolitica();

                if (MessageBox.Show("Desea Eliminar la Politica con ID: " + usuarioID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaPolitica(politicaID));
                    cargaPoliticas();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaPolitica()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridPoliticas.CurrentRow.Index);
                politicaID = int.Parse(gridPoliticas.Rows[posicion_list].Cells[0].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTAsignaPolitica_Click(object sender, EventArgs e)
        {
            seleccionaRol();
            seleccionaModulo();
            EdicionPolitica edicionPolitica = new EdicionPolitica(seguridadBL, rolID, moduloID, rol, modulo);
            edicionPolitica.ShowDialog();
            cargaPoliticas();
        }

        private void seleccionaModulo()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridModulos.CurrentRow.Index);
                moduloID = int.Parse(gridModulos.Rows[posicion_list].Cells[0].Value.ToString());
                modulo = gridModulos.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Seguridad

        #region Inv. Sucursales

        private void btBuscaInvSuc_Click(object sender, EventArgs e)
        {
            cargaInvSucursal();
        }

        private void cargaInvSucursal()
        {
            string sucursalID = string.Empty;
            ConsultaInvSucursal consulta = new ConsultaInvSucursal();
            consulta.ShowDialog();
            
            string fechaDe = consulta.fechaDe.Year.ToString() + "/";
            fechaDe += (consulta.fechaDe.Month.ToString().Length == 1) ? "0" + consulta.fechaDe.Month.ToString() + "/" : consulta.fechaDe.Month.ToString() + "/";
            fechaDe += (consulta.fechaDe.Day.ToString().Length == 1) ? "0" + consulta.fechaDe.Day.ToString() : consulta.fechaDe.Day.ToString();
            fechaDe += " 00:00:01";
            string fechaA = consulta.fechaA.Year.ToString() + "/";
            fechaA += (consulta.fechaA.Month.ToString().Length == 1) ? "0" + consulta.fechaA.Month.ToString() + "/" : consulta.fechaA.Month.ToString() + "/";
            fechaA += (consulta.fechaA.Day.ToString().Length == 1) ? "0" + consulta.fechaA.Day.ToString() : consulta.fechaA.Day.ToString();
            fechaA += " 23:59:59";
            string tipo = consulta.tipo;

            consulta.Dispose();
            
            try
            {
                foreach (DataRow row in tablaSucursales.Rows)
                {
                    if (row["nombre"].Equals(cbSucursalInv.Text.Trim()))
                    {
                        sucursalID = row["sucursalID"].ToString();
                        break;
                    }
                }

                tablaInvSucursal = new DataTable();
                tablaInvSucursal = invSucursalBL.getInvSucursal(sucursalID, txtArtSucursal.Text, fechaDe, fechaA, tipo);
                gridInvSucursal.DataSource = tablaInvSucursal;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            string sucursalID = string.Empty;

            foreach (DataRow row in tablaSucursales.Rows)
            {
                if (row["nombre"].Equals(cbSucursalInv.Text.Trim()))
                {
                    sucursalID = row["sucursalID"].ToString();
                    break;
                }
            }

            if (!string.IsNullOrEmpty(sucursalID))
            {
                if (invSucursalBL.setSolicitaCarga(sucursalID) > 0)
                    MessageBox.Show("Se generó correctamente la solicitud", "Solicitud Satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al generar solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Favor de seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btExportaInvSucursal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(invSucursalBL.genera_reporte(tablaInvSucursal, cbSucursalInv.Text.Trim()));
        }

        #endregion Inv. Sucursales

        #region Respaldos

        private void cbBuscaRespaldo_Click(object sender, EventArgs e)
        {
            cargaRespaldos();
        }

        private void cargaRespaldos()
        {
            try
            {
                string sucursalID = string.Empty;

                foreach (DataRow row in tablaSucursales.Rows)
                {
                    if (row["nombre"].Equals(cbRespaldos.Text.Trim()))
                    {
                        sucursalID = row["sucursalID"].ToString();
                        break;
                    }
                }

                DataTable table = respaldosBL.getRespaldos(sucursalID);
                gridRespaldos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Respaldos

    }
}