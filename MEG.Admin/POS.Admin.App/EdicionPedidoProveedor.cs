using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;
using POS.Admin.Identities;

namespace POS.Admin.Appl
{
    public partial class EdicionPedidoProveedor : Form
    {
        private PedidosProveedorBL pedidosProveedorBL;
        private PedidosProveedor pedidosProveedor;
        private Objetos.TipoTransaccion tipoTransaccion;
        private DataTable tablaSucursales;
        private DataTable tablaProveedores;
        private PedidoProveedorDetalle pedidoProveedorDetalle;
        private DataTable tablaDetalle = new DataTable();

        public EdicionPedidoProveedor(Objetos.TipoTransaccion _tipoTransaccion, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        public EdicionPedidoProveedor(Objetos.TipoTransaccion _tipoTransaccion, PedidosProveedor _pedidosProveedor, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            pedidosProveedor = _pedidosProveedor;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            pedidosProveedor = new PedidosProveedor();
            pedidoProveedorDetalle = new PedidoProveedorDetalle();
            tablaProveedores = new DataTable();
            tablaSucursales = new DataTable();
            pedidosProveedorBL = new PedidosProveedorBL();
            tablaDetalle = new DataTable();
        }

        private void EdicionOrden_Load(object sender, EventArgs e)
        {
            CBProveedor.Items.Clear();
            foreach (DataRow row in tablaProveedores.Rows)
                CBProveedor.Items.Add(row["descripcion"]);

            CBSucural.Items.Clear();
            foreach (DataRow row in tablaSucursales.Rows)
                CBSucural.Items.Add(row["nombre"]);

            CBEstatus.Items.Clear();
            CBEstatus.Items.Add(Objetos.EstatusOrden.PENDIENTE.ToString());
            CBEstatus.Items.Add(Objetos.EstatusOrden.PROCESADA.ToString());

            CBSucural.Text = pedidosProveedor.sucursalID;
            CBProveedor.Text = pedidosProveedor.proveedorID;
            CBEstatus.Text = pedidosProveedor.estatus;
            txtFactura.Text = pedidosProveedor.referencia;
            lblSubtotal.Text = (pedidosProveedor.subtotal.Length > 0) ? pedidosProveedor.subtotal : "0.00";
            lblIva.Text = (pedidosProveedor.total_iva.Length > 0) ? pedidosProveedor.total_iva : "0.00";
            lblTotal.Text = (pedidosProveedor.grantotal.Length > 0) ? pedidosProveedor.grantotal : "0.00";

            validaciones();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
                obtieneDetalle(pedidosProveedor.id, false);
            else if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                CBEstatus.Text = Objetos.EstatusEntrada.PENDIENTE.ToString();
                CBEstatus.Enabled = false;
            }
        }

        private void validaciones()
        {
            if (pedidosProveedor.estatus.Equals(Objetos.EstatusOrden.PROCESADA.ToString()) || pedidosProveedor.estatus.Equals(Objetos.EstatusOrden.RECIBIDA.ToString()))
            {
                CBSucural.Enabled = false;
                CBProveedor.Enabled = false;
                CBEstatus.Enabled = false;
                btNuevo.Enabled = false;
                btGuardar.Enabled = false;
                btEliminar.Enabled = false;
                GridDetalleOrden.Enabled = false;
            }
        }

        private void obtieneDetalle(string pedidoID, bool calcular)
        {
            tablaDetalle = pedidosProveedorBL.getDetalle(pedidoID);
            GridDetalleOrden.DataSource = tablaDetalle;

            if (calcular)
            {
                decimal _subtotal = 0;
                decimal _iva = 0;
                decimal _total = 0;

                pedidosProveedorBL.calculaTotal(tablaDetalle, ref _subtotal, ref _iva, ref _total);

                lblSubtotal.Text = _subtotal.ToString();
                lblIva.Text = _iva.ToString();
                lblTotal.Text = _total.ToString();
            }
        }

        private void GridDetalleOrden_DoubleClick(object sender, EventArgs e)
        {
            obtieneLineaDetalle(false);
            EdicionPedidoProveedorDetalle edicionPedidoProveedorDetalle = new EdicionPedidoProveedorDetalle(Objetos.TipoTransaccion.UPDATE, pedidoProveedorDetalle);
            edicionPedidoProveedorDetalle.ShowDialog();
            obtieneDetalle(pedidosProveedor.id, true);
        }

        private void obtieneLineaDetalle(bool quitar)
        {
            pedidoProveedorDetalle = new PedidoProveedorDetalle();
            int posicion_list = Convert.ToInt32(GridDetalleOrden.CurrentRow.Index);
            posicion_list -= (quitar && posicion_list > 0) ? 1 : 0;
            pedidoProveedorDetalle.id = GridDetalleOrden.Rows[posicion_list].Cells[0].Value.ToString();
            pedidoProveedorDetalle.ean = GridDetalleOrden.Rows[posicion_list].Cells[1].Value.ToString();
            pedidoProveedorDetalle.descripcion = GridDetalleOrden.Rows[posicion_list].Cells[2].Value.ToString();
            pedidoProveedorDetalle.cantidad = GridDetalleOrden.Rows[posicion_list].Cells[3].Value.ToString();
            pedidoProveedorDetalle.venta = GridDetalleOrden.Rows[posicion_list].Cells[4].Value.ToString();
            pedidoProveedorDetalle.costo = GridDetalleOrden.Rows[posicion_list].Cells[5].Value.ToString();
            pedidoProveedorDetalle.iva = GridDetalleOrden.Rows[posicion_list].Cells[6].Value.ToString();
            pedidoProveedorDetalle.subtotal = GridDetalleOrden.Rows[posicion_list].Cells[7].Value.ToString();
            pedidoProveedorDetalle.total = GridDetalleOrden.Rows[posicion_list].Cells[9].Value.ToString();
            pedidoProveedorDetalle.porcentaje_iva = GridDetalleOrden.Rows[posicion_list].Cells[10].Value.ToString();
            pedidoProveedorDetalle.pedidoID = pedidosProveedor.id;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DataRow[] rows = Globales.tablaSucursales.Select("nombre = '" + CBSucural.Text.Trim() + "'");
            pedidosProveedor.sucursalID = rows[0].ItemArray[0].ToString();

            rows = Globales.tablaProveedores.Select("descripcion = '" + CBProveedor.Text.Trim() + "'");
            pedidosProveedor.proveedorID = rows[0].ItemArray[0].ToString();

            pedidosProveedor.estatus = CBEstatus.Text.Trim();

            pedidosProveedor.referencia = txtFactura.Text;
            pedidosProveedor.subtotal = lblSubtotal.Text;
            pedidosProveedor.total_iva = lblIva.Text;
            pedidosProveedor.grantotal = lblTotal.Text;

            MessageBox.Show(pedidosProveedorBL.setPedidos(ref pedidosProveedor, ref tipoTransaccion, Globales.empresaId));

            validaciones();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EdicionPedidoProveedorDetalle edicionPedidoProveedorDetalle = new EdicionPedidoProveedorDetalle(Objetos.TipoTransaccion.INSERT, pedidosProveedor.id);
            edicionPedidoProveedorDetalle.ShowDialog();
            obtieneDetalle(pedidosProveedor.id, true);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obtieneLineaDetalle(false);

                if (MessageBox.Show("Desea Eliminar el Artículo con ID: " + pedidoProveedorDetalle.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(pedidosProveedorBL.eliminaDetalle(pedidoProveedorDetalle));
                    obtieneDetalle(pedidosProveedor.id, true);
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExporta_Click(object sender, EventArgs e)
        {
            if (GridDetalleOrden.Rows.Count > 0)
                MessageBox.Show(pedidosProveedorBL.genera_reporte(pedidosProveedor, tablaDetalle), "Exportar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btReportear_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 1;
            reportes.OrdenID = pedidosProveedor.id;
            reportes.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void GridDetalleOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                obtieneLineaDetalle(true);
                EdicionPedidoProveedorDetalle edicionPedidoProveedorDetalle = new EdicionPedidoProveedorDetalle(Objetos.TipoTransaccion.UPDATE, pedidoProveedorDetalle);
                edicionPedidoProveedorDetalle.ShowDialog();
                obtieneDetalle(pedidosProveedor.id, true);
            }
        }
    }
}