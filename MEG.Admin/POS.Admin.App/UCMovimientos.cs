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
    public partial class UCMovimientos : UserControl
    {
        #region Variables

        private Ordenes ordenes;
        private OrdenesBL ordenesBL;
        private Entradas entradas;
        private EntradasBL entradasBL;
        private InventariosBL inventariosBL;
        private DevolucionOrden devolucionOrden;
        private DevolucionOrdenBL devolucionOrdenBL;
        private InvSucursalBL invSucursalBL;
        private PedidosProveedorBL pedidosProveedorBL;
        private PedidosProveedor pedidosProveedor;

        #endregion Variables

        public UCMovimientos()
        {
            InitializeComponent();
        }

        public void aplicaPoliticas()
        {
            ordenes = new Ordenes();
            ordenesBL = new OrdenesBL();
            entradas = new Entradas();
            entradasBL = new EntradasBL();
            inventariosBL = new InventariosBL();
            devolucionOrden = new DevolucionOrden();
            devolucionOrdenBL = new DevolucionOrdenBL();
            invSucursalBL = new InvSucursalBL();
            pedidosProveedorBL = new PedidosProveedorBL();
            pedidosProveedor = new PedidosProveedor();

            cbProveedorInv.Items.Clear();
            foreach (DataRow row in Globales.tablaProveedores.Rows)
            {
                if (row["almacen"].Equals(true))
                    cbProveedorInv.Items.Add(row["descripcion"]);
            }

            cbSucursalInv.Items.Clear();
            foreach (DataRow row in Globales.tablaSucursales.Rows)
            {
                cbSucursalInv.Items.Add(row["nombre"]);
            }

            CBEstatus.Items.Clear();
            CBEstatus.Items.AddRange(Globales.estatus.ToArray());

            foreach (DataRow row in Globales.tablaAccesos.Rows)
            {
                switch (row["modulo"].ToString())
                {
                    case "ORDENES":
                        BTNuevaOrden.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaOrden = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaOrden.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaOrden.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "DEVOLUCIONES":
                        btNuevaDev.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaDevolucion = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        btEliminaDev.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        btBuscaDev.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "INVENTARIOS":
                        btBuscaInv.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "ENTRADAS":
                        BTNuevaEntrada.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaEntrada = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaEntrada.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaEntrada.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "CUENTAS POR COBRAR":
                        //BTNuevaEntrada.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaCuentasCobro = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        //BTEliminaEntrada.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        //BTBuscaEntrada.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "PEDIDOS A PROVEEDOR":
                        btNuevoPedido.Enabled = (Convert.ToBoolean(row["agregar"])) ? true : false;
                        Globales.modificaPedidoProveedor = (Convert.ToBoolean(row["modificar"])) ? true : false;
                        BTEliminaEntrada.Enabled = (Convert.ToBoolean(row["eliminar"])) ? true : false;
                        BTBuscaEntrada.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    case "MOVIMIENTOS":
                        gbMovimientos.Enabled = (Convert.ToBoolean(row["visualizar"])) ? true : false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UCMovimientos_Load(object sender, EventArgs e)
        {

        }

        #region Ordenes

        private void GridOrdenes_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaOrden)
            {
                seleccionaOrden();
                EdicionOrden edicionOrden = new EdicionOrden(Objetos.TipoTransaccion.UPDATE, ordenes, Globales.tablaProveedores, Globales.tablaSucursales);
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
                DataTable table = ordenesBL.getOrdenes(txtFactura.Text, txtOrden.Text, Globales.empresaId);
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

            objParameter.strProc = "sel_ordenes";
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
                EdicionOrden edicionOrden = new EdicionOrden(Objetos.TipoTransaccion.INSERT, Globales.tablaProveedores, Globales.tablaSucursales);
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

        #region Entradas

        private void BTBuscaEntrada_Click(object sender, EventArgs e)
        {
            cargaEntradas();
        }

        private void cargaEntradas()
        {
            try
            {
                DataTable table = entradasBL.getEntradas(txtFacturaAlmacen.Text, txtFolioAlmacen.Text, Globales.empresaId);
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
                EdicionEntrada EdicionEntrada = new EdicionEntrada(Objetos.TipoTransaccion.INSERT, Globales.tablaProveedores);
                EdicionEntrada.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridEntradas_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaEntrada)
            {
                seleccionaEntrada();
                EdicionEntrada edicionEntrada = new EdicionEntrada(Objetos.TipoTransaccion.UPDATE, entradas, Globales.tablaProveedores);
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
                if (string.IsNullOrEmpty(cbProveedorInv.Text.Trim()))
                    MessageBox.Show("Favor de seleccionar un Almacen");
                else
                {
                    DataRow[] rows = Globales.tablaProveedores.Select("descripcion = '" + cbProveedorInv.Text.Trim() + "'");
                    proveedorID = rows[0].ItemArray[0].ToString();

                    Globales.tablaInventarios = new DataTable();
                    Globales.tablaInventarios = inventariosBL.getInventarios(proveedorID, txtDescripcionInv.Text);
                    gridInventarios.DataSource = Globales.tablaInventarios;
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExportarInv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inventariosBL.genera_reporte(Globales.tablaInventarios));
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
                DataTable table = devolucionOrdenBL.getDevolucionOrden(txtNoDevolucion.Text, Globales.empresaId);
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
                EdicionDevolucionOrden edicionDevOrden = new EdicionDevolucionOrden(Objetos.TipoTransaccion.INSERT, Globales.tablaProveedores, Globales.tablaSucursales);
                edicionDevOrden.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDevoluciones_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaDevolucion)
            {
                seleccionaDevOrden();
                EdicionDevolucionOrden edicionDevOrden = new EdicionDevolucionOrden(Objetos.TipoTransaccion.UPDATE, devolucionOrden, Globales.tablaProveedores, Globales.tablaSucursales);
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
                devolucionOrden.referencia = gridDevoluciones.Rows[posicion_list].Cells[4].Value.ToString();
                devolucionOrden.subtotal = gridDevoluciones.Rows[posicion_list].Cells[5].Value.ToString();
                devolucionOrden.total_iva = gridDevoluciones.Rows[posicion_list].Cells[6].Value.ToString();
                devolucionOrden.grantotal = gridDevoluciones.Rows[posicion_list].Cells[7].Value.ToString();
                devolucionOrden.estatus = gridDevoluciones.Rows[posicion_list].Cells[8].Value.ToString();
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

        #region Inv. Sucursales

        private void btBuscaInvSuc_Click(object sender, EventArgs e)
        {
            cargaInvSucursal();
        }

        private void cargaInvSucursal()
        {
            try
            {
                if (string.IsNullOrEmpty(cbSucursalInv.Text.Trim()))
                    MessageBox.Show("Favor de seleccionar una Sucursal");
                else
                {
                    DataRow[] rows = Globales.tablaSucursales.Select("nombre = '" + cbSucursalInv.Text.Trim() + "'");

                    Globales.tablaInvSucursal = new DataTable();
                    Globales.tablaInvSucursal = invSucursalBL.getInvSucursal(rows[0].ItemArray[0].ToString(), txtArtSucursal.Text);
                    gridInvSucursal.DataSource = Globales.tablaInvSucursal;
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            string sucursalID = string.Empty;

            foreach (DataRow row in Globales.tablaSucursales.Rows)
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
            MessageBox.Show(invSucursalBL.genera_reporte(Globales.tablaInvSucursal, cbSucursalInv.Text.Trim()));
        }

        #endregion Inv. Sucursales

        #region Pedidos Proveedor

        private void seleccionaPedido()
        {
            try
            {
                pedidosProveedor = new PedidosProveedor();
                int posicion_list = Convert.ToInt32(gridPedidos.CurrentRow.Index);
                pedidosProveedor.id = gridPedidos.Rows[posicion_list].Cells[0].Value.ToString();
                pedidosProveedor.sucursalID = gridPedidos.Rows[posicion_list].Cells[1].Value.ToString();
                pedidosProveedor.proveedorID = gridPedidos.Rows[posicion_list].Cells[2].Value.ToString();
                pedidosProveedor.referencia = gridPedidos.Rows[posicion_list].Cells[3].Value.ToString();
                pedidosProveedor.subtotal = gridPedidos.Rows[posicion_list].Cells[4].Value.ToString();
                pedidosProveedor.total_iva = gridPedidos.Rows[posicion_list].Cells[5].Value.ToString();
                pedidosProveedor.grantotal = gridPedidos.Rows[posicion_list].Cells[6].Value.ToString();
                pedidosProveedor.estatus = gridPedidos.Rows[posicion_list].Cells[7].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargaPedidos()
        {
            try
            {
                DataTable table = pedidosProveedorBL.getPedidos(txtReferenciaPedido.Text, Globales.empresaId);
                gridPedidos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btBuscaPedido_Click(object sender, EventArgs e)
        {
            cargaPedidos();
        }

        private void btNuevoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                EdicionPedidoProveedor edicionPedidoProveedor = new EdicionPedidoProveedor(Objetos.TipoTransaccion.INSERT, Globales.tablaProveedores, Globales.tablaSucursales);
                edicionPedidoProveedor.ShowDialog();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminaPedido_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaPedido();

                if (MessageBox.Show("Desea Eliminar el Pedido con ID: " + pedidosProveedor.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(pedidosProveedorBL.eliminaPedido(pedidosProveedor));
                    cargaPedidos();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (Globales.modificaPedidoProveedor)
            {
                seleccionaPedido();
                EdicionPedidoProveedor edicionPedidoProveedor = new EdicionPedidoProveedor(Objetos.TipoTransaccion.UPDATE, pedidosProveedor, Globales.tablaProveedores, Globales.tablaSucursales);
                edicionPedidoProveedor.ShowDialog();
                cargaPedidos();
            }
        }

        #endregion Pedidos Proveedor

        #region Estadistica

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

        #endregion Estadistica

        private void btPropinas_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 6;
            reportes.ShowDialog();
        }

        private void btVentaGral_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 7;
            reportes.ShowDialog();
        }

        private void btArticulo_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 8;
            reportes.ShowDialog();
        }

        private void btTops_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 9;
            reportes.ShowDialog();
        }

        private void btBuscaCuenta_Click(object sender, EventArgs e)
        {

        }

    }
}
