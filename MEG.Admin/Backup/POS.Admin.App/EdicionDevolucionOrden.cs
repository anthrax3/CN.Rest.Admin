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
    public partial class EdicionDevolucionOrden : Form
    {
        private DevolucionOrdenBL devolucionOrdenBL;
        private DevolucionOrden devolucionOrden;
        private Objetos.TipoTransaccion tipoTransaccion;
        private DataTable tablaSucursales;
        private DataTable tablaProveedores;
        private devolucionOrdenDetalle DevolucionOrdenDetalle;
        private DataTable tablaDetalle = new DataTable();

        public EdicionDevolucionOrden(Objetos.TipoTransaccion _tipoTransaccion, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        public EdicionDevolucionOrden(Objetos.TipoTransaccion _tipoTransaccion, DevolucionOrden _devolucionOrden, DataTable _tablaProveedores, DataTable _tablaSucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            devolucionOrden = _devolucionOrden;
            tablaSucursales = _tablaSucursales;
            tablaProveedores = _tablaProveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            devolucionOrden = new DevolucionOrden();
            DevolucionOrdenDetalle = new devolucionOrdenDetalle();
            tablaProveedores = new DataTable();
            tablaSucursales = new DataTable();
            devolucionOrdenBL = new DevolucionOrdenBL();
            tablaDetalle = new DataTable();
        }

        private void EdicionDevolucionOrden_Load(object sender, EventArgs e)
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

            CBSucural.Text = devolucionOrden.sucursalID;
            CBProveedor.Text = devolucionOrden.proveedorID;
            CBEstatus.Text = devolucionOrden.estatus;
            txtOrden.Text = devolucionOrden.noOrden;
            txtReferencia.Text = devolucionOrden.referencia;
            lblSubtotal.Text = (devolucionOrden.subtotal.Length > 0) ? devolucionOrden.subtotal : "0.00";
            lblIva.Text = (devolucionOrden.total_iva.Length > 0) ? devolucionOrden.total_iva : "0.00";
            lblTotal.Text = (devolucionOrden.grantotal.Length > 0) ? devolucionOrden.grantotal : "0.00";

            validaciones();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
                obtieneDetalle(devolucionOrden.id, false);
            else if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                CBEstatus.Text = Objetos.EstatusEntrada.PENDIENTE.ToString();
                CBEstatus.Enabled = false;
            }
        }

        private void validaciones()
        {
            if (devolucionOrden.estatus.Equals(Objetos.EstatusOrden.PROCESADA.ToString()) || devolucionOrden.estatus.Equals(Objetos.EstatusOrden.RECIBIDA.ToString()))
            {
                CBSucural.Enabled = false;
                CBProveedor.Enabled = false;
                CBEstatus.Enabled = false;
                btNuevo.Enabled = false;
                btGuardar.Enabled = false;
                GridDetalleDevOrden.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        private void obtieneDetalle(string devolucionOrdenID, bool calcular)
        {
            tablaDetalle = devolucionOrdenBL.getDevOrdenDetalle(devolucionOrdenID);
            GridDetalleDevOrden.DataSource = tablaDetalle;

            if (calcular)
            {
                decimal _subtotal = 0;
                decimal _iva = 0;
                decimal _total = 0;

                devolucionOrdenBL.calculaTotal(tablaDetalle, ref _subtotal, ref _iva, ref _total);

                lblSubtotal.Text = _subtotal.ToString();
                lblIva.Text = _iva.ToString();
                lblTotal.Text = _total.ToString();
            }
        }

        private void obtieneLineaDetalle(bool quitar)
        {
            DevolucionOrdenDetalle = new devolucionOrdenDetalle();
            int posicion_list = Convert.ToInt32(GridDetalleDevOrden.CurrentRow.Index);
            posicion_list -= (quitar && posicion_list > 0) ? 1 : 0;
            DevolucionOrdenDetalle.id = GridDetalleDevOrden.Rows[posicion_list].Cells[0].Value.ToString();
            DevolucionOrdenDetalle.ean = GridDetalleDevOrden.Rows[posicion_list].Cells[1].Value.ToString();
            DevolucionOrdenDetalle.descripcion = GridDetalleDevOrden.Rows[posicion_list].Cells[2].Value.ToString();
            DevolucionOrdenDetalle.cantidad = GridDetalleDevOrden.Rows[posicion_list].Cells[3].Value.ToString();
            DevolucionOrdenDetalle.costo = GridDetalleDevOrden.Rows[posicion_list].Cells[4].Value.ToString();
            DevolucionOrdenDetalle.venta = GridDetalleDevOrden.Rows[posicion_list].Cells[5].Value.ToString();
            DevolucionOrdenDetalle.subtotal = GridDetalleDevOrden.Rows[posicion_list].Cells[6].Value.ToString();
            DevolucionOrdenDetalle.iva = GridDetalleDevOrden.Rows[posicion_list].Cells[7].Value.ToString();
            DevolucionOrdenDetalle.total = GridDetalleDevOrden.Rows[posicion_list].Cells[8].Value.ToString();
            DevolucionOrdenDetalle.porcentaje_iva = GridDetalleDevOrden.Rows[posicion_list].Cells[9].Value.ToString();
            DevolucionOrdenDetalle.devolucionOrdenID = devolucionOrden.id;
        }

        private void GridDetalleDevOrden_DoubleClick(object sender, EventArgs e)
        {
            obtieneLineaDetalle(false);
            EdicionDevOrdenDetalle edicionDevOrdenDetalle = new EdicionDevOrdenDetalle(Objetos.TipoTransaccion.UPDATE, DevolucionOrdenDetalle);
            edicionDevOrdenDetalle.ShowDialog();
            obtieneDetalle(devolucionOrden.id, true);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DataRow[] rows = Globales.tablaSucursales.Select("nombre = '" + CBSucural.Text.Trim() + "'");
            devolucionOrden.sucursalID = rows[0].ItemArray[0].ToString();

            rows = Globales.tablaProveedores.Select("descripcion = '" + CBProveedor.Text.Trim() + "'");
            devolucionOrden.proveedorID = rows[0].ItemArray[0].ToString();

            devolucionOrden.estatus = CBEstatus.Text.Trim();

            devolucionOrden.noOrden = txtOrden.Text;
            devolucionOrden.referencia = txtReferencia.Text;
            devolucionOrden.subtotal = lblSubtotal.Text;
            devolucionOrden.total_iva = lblIva.Text;
            devolucionOrden.grantotal = lblTotal.Text;

            MessageBox.Show(devolucionOrdenBL.setDevolucionOrden(ref devolucionOrden, ref tipoTransaccion));

            validaciones();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EdicionDevOrdenDetalle edicionDevOrdenDetalle = new EdicionDevOrdenDetalle(Objetos.TipoTransaccion.INSERT, devolucionOrden.id);
            edicionDevOrdenDetalle.ShowDialog();
            obtieneDetalle(devolucionOrden.id, true);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obtieneLineaDetalle(false);

                if (MessageBox.Show("Desea Eliminar el Artículo con ID: " + DevolucionOrdenDetalle.devolucionOrdenID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(devolucionOrdenBL.eliminaDevOrdenDetalle(DevolucionOrdenDetalle));
                    obtieneDetalle(devolucionOrden.id, true);
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void GridDetalleDevOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                obtieneLineaDetalle(true);
                EdicionDevOrdenDetalle edicionDevOrdenDetalle = new EdicionDevOrdenDetalle(Objetos.TipoTransaccion.UPDATE, DevolucionOrdenDetalle);
                edicionDevOrdenDetalle.ShowDialog();
                obtieneDetalle(devolucionOrden.id, true);
            }
        }

        private void btExporta_Click(object sender, EventArgs e)
        {

        }

    }
}