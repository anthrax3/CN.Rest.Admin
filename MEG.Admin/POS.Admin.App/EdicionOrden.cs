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
    public partial class EdicionOrden : Form
    {
        private OrdenesBL ordenesBL;
        private Ordenes ordenes;
        private Objetos.TipoTransaccion tipoTransaccion;
        private DataTable tablaSucursales;
        private DataTable tablaProveedores;
        private ordenDetalle ordendetalle;
        private DataTable tablaDetalle = new DataTable();

        public EdicionOrden(Objetos.TipoTransaccion _tipoTransaccion, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        public EdicionOrden(Objetos.TipoTransaccion _tipoTransaccion, Ordenes _ordenes, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            ordenes = _ordenes;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            ordenes = new Ordenes();
            ordendetalle = new ordenDetalle();
            tablaProveedores = new DataTable();
            tablaSucursales = new DataTable();
            ordenesBL = new OrdenesBL();
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

            CBSucural.Text = ordenes.sucursalID;
            CBProveedor.Text = ordenes.proveedorID;
            CBEstatus.Text = ordenes.estatus;
            txtFactura.Text = ordenes.factura;
            txtOrden.Text = ordenes.noOrden;
            lblSubtotal.Text = (ordenes.subtotal.Length > 0) ? ordenes.subtotal : "0.00";
            lblIva.Text = (ordenes.total_iva.Length > 0) ? ordenes.total_iva : "0.00";
            lblTotal.Text = (ordenes.grantotal.Length > 0) ? ordenes.grantotal : "0.00";

            validaciones();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
                obtieneDetalle(ordenes.id, false);
            else if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                CBEstatus.Text = Objetos.EstatusEntrada.PENDIENTE.ToString();
                CBEstatus.Enabled = false;
            }
        }

        private void validaciones()
        {
            if (ordenes.estatus.Equals(Objetos.EstatusOrden.PROCESADA.ToString()) || ordenes.estatus.Equals(Objetos.EstatusOrden.RECIBIDA.ToString()))
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

        private void obtieneDetalle(string ordenID, bool calcular)
        {
            tablaDetalle = ordenesBL.getDetalle(ordenID);
            GridDetalleOrden.DataSource = tablaDetalle;

            if (calcular)
            {
                decimal _subtotal = 0;
                decimal _iva = 0;
                decimal _total = 0;

                ordenesBL.calculaTotal(tablaDetalle, ref _subtotal, ref _iva, ref _total);

                lblSubtotal.Text = _subtotal.ToString();
                lblIva.Text = _iva.ToString();
                lblTotal.Text = _total.ToString();
            }
        }

        private void GridDetalleOrden_DoubleClick(object sender, EventArgs e)
        {
            obtieneLineaDetalle(false);
            EdicionOrdenDetalle ordenDetalle = new EdicionOrdenDetalle(Objetos.TipoTransaccion.UPDATE, ordendetalle);
            ordenDetalle.ShowDialog();
            obtieneDetalle(ordenes.id, true);
        }

        private void obtieneLineaDetalle(bool quitar)
        {
            ordendetalle = new ordenDetalle();
            int posicion_list = Convert.ToInt32(GridDetalleOrden.CurrentRow.Index);
            posicion_list -= (quitar && posicion_list > 0) ? 1 : 0;
            ordendetalle.id = GridDetalleOrden.Rows[posicion_list].Cells[0].Value.ToString();
            ordendetalle.ean = GridDetalleOrden.Rows[posicion_list].Cells[1].Value.ToString();
            ordendetalle.descripcion = GridDetalleOrden.Rows[posicion_list].Cells[2].Value.ToString();
            ordendetalle.cantidad = GridDetalleOrden.Rows[posicion_list].Cells[3].Value.ToString();
            ordendetalle.venta = GridDetalleOrden.Rows[posicion_list].Cells[4].Value.ToString();
            ordendetalle.costo = GridDetalleOrden.Rows[posicion_list].Cells[5].Value.ToString();
            ordendetalle.iva = GridDetalleOrden.Rows[posicion_list].Cells[6].Value.ToString();
            ordendetalle.subtotal = GridDetalleOrden.Rows[posicion_list].Cells[7].Value.ToString();
            ordendetalle.total = GridDetalleOrden.Rows[posicion_list].Cells[9].Value.ToString();
            ordendetalle.porcentaje_iva = GridDetalleOrden.Rows[posicion_list].Cells[10].Value.ToString();
            ordendetalle.ordenID = ordenes.id;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DataRow[] rows = Globales.tablaSucursales.Select("nombre = '" + CBSucural.Text.Trim() + "'");
            ordenes.sucursalID = rows[0].ItemArray[0].ToString();

            rows = Globales.tablaProveedores.Select("descripcion = '" + CBProveedor.Text.Trim() + "'");
            ordenes.proveedorID = rows[0].ItemArray[0].ToString();

            ordenes.estatus = CBEstatus.Text.Trim();

            ordenes.factura = txtFactura.Text;
            ordenes.noOrden = txtOrden.Text;
            ordenes.subtotal = lblSubtotal.Text;
            ordenes.total_iva = lblIva.Text;
            ordenes.grantotal = lblTotal.Text;

            MessageBox.Show(ordenesBL.setOrdenes(ref ordenes, ref tipoTransaccion, Globales.empresaId));

            validaciones();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EdicionOrdenDetalle ordenDetalle = new EdicionOrdenDetalle(Objetos.TipoTransaccion.INSERT, ordenes.id);
            ordenDetalle.ShowDialog();
            obtieneDetalle(ordenes.id, true);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obtieneLineaDetalle(false);

                if (MessageBox.Show("Desea Eliminar el Artículo con ID: " + ordendetalle.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(ordenesBL.eliminaDetalle(ordendetalle));
                    obtieneDetalle(ordenes.id, true);
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
                MessageBox.Show(ordenesBL.genera_reporte(ordenes, tablaDetalle), "Exportar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btReportear_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 1;
            reportes.OrdenID = ordenes.id;
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
                EdicionOrdenDetalle ordenDetalle = new EdicionOrdenDetalle(Objetos.TipoTransaccion.UPDATE, ordendetalle);
                ordenDetalle.ShowDialog();
                obtieneDetalle(ordenes.id, true);
            }
        }
    }
}