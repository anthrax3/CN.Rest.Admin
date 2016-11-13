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
    public partial class EdicionEntrada : Form
    {
        private EntradasBL entradasBL;
        private Entradas entradas;
        private Objetos.TipoTransaccion tipoTransaccion;
        private DataTable tablaProveedores;
        private EntradaDetalle entradaDetalle;
        private DataTable tablaDetalle = new DataTable();

        public EdicionEntrada(Objetos.TipoTransaccion _tipoTransaccion, DataTable _tablaProveedores)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            tablaProveedores = _tablaProveedores;
        }

        public EdicionEntrada(Objetos.TipoTransaccion _tipoTransaccion, Entradas _entradas, DataTable _tablaProveedores)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            entradas = _entradas;
            tablaProveedores = _tablaProveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            entradas = new Entradas();
            entradaDetalle = new EntradaDetalle();
            tablaProveedores = new DataTable();
            entradasBL = new EntradasBL();
            tablaDetalle = new DataTable();
        }

        private void EdicionEntrada_Load(object sender, EventArgs e)
        {
            CBProveedor.Items.Clear();
            foreach (DataRow row in tablaProveedores.Rows)
            {
                if (row["almacen"].Equals(true))
                    CBProveedor.Items.Add(row["descripcion"]);
            }

            CBProvFactura.Items.Clear();
            foreach (DataRow row in tablaProveedores.Rows)
            {
                if (row["almacen"].Equals(false))
                    CBProvFactura.Items.Add(row["descripcion"]);
            }

            CBEstatus.Items.Add(Objetos.EstatusEntrada.PENDIENTE.ToString());
            CBEstatus.Items.Add(Objetos.EstatusEntrada.INGRESADA.ToString());
            CBEstatus.Items.Add(Objetos.EstatusEntrada.CANCELADA.ToString());

            CBProveedor.Text = entradas.proveedorID;
            CBProvFactura.Text = entradas.proveedor_compraID;
            CBEstatus.Text = entradas.estatus;
            txtFactura.Text = entradas.factura;
            txtFolio.Text = entradas.folio;
            lblImporteCero.Text = (entradas.importeCero.Length > 0) ? entradas.importeCero : "0.00";
            lblImporteQuince.Text = (entradas.importeQuince.Length > 0) ? entradas.importeQuince : "0.00";

            validaciones();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
                obtieneDetalle(entradas.entradaID, false);
            else if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                CBEstatus.Text = Objetos.EstatusEntrada.PENDIENTE.ToString();
                CBEstatus.Enabled = false;
            }
        }

        private void validaciones()
        {
            if (entradas.estatus.Equals(Objetos.EstatusEntrada.INGRESADA.ToString()) || entradas.estatus.Equals(Objetos.EstatusEntrada.CANCELADA.ToString()))
            {
                CBProveedor.Enabled = false;
                CBProvFactura.Enabled = false;
                CBEstatus.Enabled = false;
                btNuevo.Enabled = false;
                btGuardar.Enabled = false;
                GridDetalleEntrada.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        private void obtieneDetalle(string entradaID, bool calcular)
        {
            tablaDetalle = entradasBL.getDetalle(entradaID);
            GridDetalleEntrada.DataSource = tablaDetalle;

            if (calcular)
            {
                decimal _totalCero = 0;
                decimal _totalQuince = 0;

                entradasBL.calculaTotal(tablaDetalle, ref _totalCero, ref _totalQuince);

                lblImporteCero.Text = _totalCero.ToString();
                lblImporteQuince.Text = _totalQuince.ToString();
            }
        }

        private void obtieneLineaDetalle(bool quitar)
        {
            entradaDetalle = new EntradaDetalle();
            int posicion_list = Convert.ToInt32(GridDetalleEntrada.CurrentRow.Index);
            posicion_list -= (quitar && posicion_list > 0) ? 1 : 0;
            entradaDetalle.id = GridDetalleEntrada.Rows[posicion_list].Cells[0].Value.ToString();
            entradaDetalle.ean = GridDetalleEntrada.Rows[posicion_list].Cells[1].Value.ToString();
            entradaDetalle.descripcion = GridDetalleEntrada.Rows[posicion_list].Cells[2].Value.ToString();
            entradaDetalle.venta = GridDetalleEntrada.Rows[posicion_list].Cells[3].Value.ToString();
            entradaDetalle.costo = GridDetalleEntrada.Rows[posicion_list].Cells[4].Value.ToString();
            entradaDetalle.cantidad = GridDetalleEntrada.Rows[posicion_list].Cells[5].Value.ToString();
            entradaDetalle.porcentaje_iva = GridDetalleEntrada.Rows[posicion_list].Cells[6].Value.ToString();
            entradaDetalle.subtotalCero = GridDetalleEntrada.Rows[posicion_list].Cells[7].Value.ToString();
            entradaDetalle.subtotalQuince = GridDetalleEntrada.Rows[posicion_list].Cells[8].Value.ToString();
            entradaDetalle.entradaID = entradas.entradaID;
        }

        private void GridDetalleEntrada_DoubleClick(object sender, EventArgs e)
        {
            obtieneLineaDetalle(false);
            EdicionEntradaDetalle ordenDetalle = new EdicionEntradaDetalle(Objetos.TipoTransaccion.UPDATE, entradaDetalle);
            ordenDetalle.ShowDialog();
            obtieneDetalle(entradas.entradaID, true);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DataRow[] rows = tablaProveedores.Select("descripcion = '" + CBProveedor.Text.Trim() + "'");
            entradas.proveedorID = rows[0].ItemArray[0].ToString();

            rows = tablaProveedores.Select("descripcion = '" + CBProvFactura.Text.Trim() + "'");
            entradas.proveedor_compraID = rows[0].ItemArray[0].ToString();

            entradas.estatus = CBEstatus.Text;
            entradas.factura = txtFactura.Text;
            entradas.folio = txtFolio.Text;
            entradas.importeCero = lblImporteCero.Text;
            entradas.importeQuince = lblImporteQuince.Text;

            MessageBox.Show(entradasBL.setEntradas(ref entradas, ref tipoTransaccion));

            validaciones();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EdicionEntradaDetalle ordenDetalle = new EdicionEntradaDetalle(Objetos.TipoTransaccion.INSERT, entradas.entradaID);
            ordenDetalle.ShowDialog();
            obtieneDetalle(entradas.entradaID, true);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obtieneLineaDetalle(false);

                if (MessageBox.Show("Desea Eliminar el Artículo con ID: " + entradaDetalle.id + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(entradasBL.eliminaDetalle(entradaDetalle.id));
                    obtieneDetalle(entradas.entradaID, true);
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

        private void GridDetalleEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                obtieneLineaDetalle(true);
                EdicionEntradaDetalle ordenDetalle = new EdicionEntradaDetalle(Objetos.TipoTransaccion.UPDATE, entradaDetalle);
                ordenDetalle.ShowDialog();
                obtieneDetalle(entradas.entradaID, true);
            }
        }

        private void btReportear_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 3;
            reportes.AlmacenID = entradas.entradaID;
            reportes.ShowDialog();
        }
    }
}