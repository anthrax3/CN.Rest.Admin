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
    public partial class EdicionEntradaDetalle : Form
    {
        private EntradaDetalle entradaDetalle;
        private EntradasBL entradasBL;
        private ArticulosBL articulosBL;
        private Objetos.TipoTransaccion tipoTransaccion;
        private string almacenID;
        private string articuloID = string.Empty;
        private decimal _iva = 0;

        public EdicionEntradaDetalle(Objetos.TipoTransaccion _tipoTransaccion, string _almacenID)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            almacenID = _almacenID;
        }

        public EdicionEntradaDetalle(Objetos.TipoTransaccion _tipoTransaccion, EntradaDetalle _entradadetalle)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            entradaDetalle = _entradadetalle;
        }

        private void inicializa()
        {
            InitializeComponent();
            entradaDetalle = new EntradaDetalle();
            entradasBL = new EntradasBL();
        }

        private void EdicionOrdenDetalle_Load(object sender, EventArgs e)
        {
            radioDescripcion.Checked = true;

            txtEan.Text = entradaDetalle.ean;
            txtDescripcion.Text = entradaDetalle.descripcion;
            txtCantidad.Text = entradaDetalle.cantidad;
            txtCosto.Text = entradaDetalle.costo;
            txtVenta.Text = entradaDetalle.venta;
            txttotalCero.Text = entradaDetalle.subtotalCero;
            txtIva.Text = entradaDetalle.porcentaje_iva;
            txtTotalQuince.Text = entradaDetalle.subtotalQuince;
            if (entradaDetalle.porcentaje_iva.Length > 0)
                _iva = Convert.ToDecimal(entradaDetalle.porcentaje_iva);

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtEan.Enabled = false;
                groupBusqueda.Enabled = false;
            }
        }

        private void txtEan_Leave(object sender, EventArgs e)
        {
            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                if (txtEan.Text != string.Empty)
                {
                    DataTable table = new OrdenesBL().getArticuloDetalle(txtEan.Text, Globales.empresaId);

                    limpiaCampos();

                    foreach (DataRow row in table.Rows)
                    {
                        articuloID = row["articuloID"].ToString();
                        txtEan.Text = row["codigo_ean"].ToString();
                        txtDescripcion.Text = row["descripcion"].ToString();
                        txtCantidad.Text = "0";
                        txtCosto.Text = row["p_costo"].ToString();
                        txtVenta.Text = row["p_venta"].ToString();
                        txttotalCero.Text = "0";
                        _iva = Convert.ToDecimal(row["iva"]);
                        txtIva.Text = "0";
                        txttotalCero.Text = "0";
                        txtTotalQuince.Text = "0";
                    }
                }
                else
                    limpiaCampos();
            }
        }

        private void limpiaCampos()
        {
            articuloID = "";
            txtEan.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
            txtVenta.Text = "";
            txttotalCero.Text = "";
            txtIva.Text = "";
            txtTotalQuince.Text = "";
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            calculaPartida();
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
            calculaPartida();
        }

        private void calculaPartida()
        {
            try
            {
                lblMensaje.Text = "";
                if ((txtCosto.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
                {
                    decimal costo = Convert.ToDecimal(txtCosto.Text);
                    decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
                    decimal subtotal = 0;
                    decimal iva = _iva;
                    decimal total = 0;
                    entradasBL.calculaPartida(costo, cantidad, ref subtotal, ref iva, ref total);

                    txttotalCero.Text = Convert.ToString(subtotal);
                    txtIva.Text = Convert.ToString(iva);
                    txtTotalQuince.Text = Convert.ToString(total);
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void txtEan_Click(object sender, EventArgs e)
        {
            txtEan.SelectAll();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                if (txtBuscar.Text != string.Empty)
                {
                    articulosBL = new ArticulosBL();

                    int tipo = 0;
                    if (radioDescripcion.Checked) tipo = 1;
                    if (radioEan.Checked) tipo = 2;

                    if (tipo > 0)
                    {
                        gridBusqueda.DataSource = articulosBL.getArticulos(txtBuscar.Text, tipo, Globales.empresaId);
                        txtBuscar.Text = "";
                    }
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void gridBusqueda_DoubleClick(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            limpiaCampos();
            txtEan.Text = obtieneDetalle(false);
            txtEan.SelectAll();
            txtEan.Focus();
        }

        private string obtieneDetalle(bool quitar)
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridBusqueda.CurrentRow.Index);
                posicion_list -= (quitar && posicion_list > 0) ? 1 : 0;
                return gridBusqueda.Rows[posicion_list].Cells[0].Value.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private void gridBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lblMensaje.Text = "";
                limpiaCampos();
                txtEan.Text = obtieneDetalle(true);
                txtEan.SelectAll();
                txtEan.Focus();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            entradaDetalle.ean = txtEan.Text;
            entradaDetalle.descripcion = txtDescripcion.Text;
            entradaDetalle.cantidad = txtCantidad.Text;
            entradaDetalle.costo = txtCosto.Text;
            entradaDetalle.venta = txtVenta.Text;
            entradaDetalle.subtotalCero = txttotalCero.Text;
            entradaDetalle.porcentaje_iva = txtIva.Text;
            entradaDetalle.subtotalQuince = txtTotalQuince.Text;

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                entradaDetalle.entradaID = almacenID;
                entradaDetalle.id = articuloID;
            }

            lblMensaje.Text = entradasBL.setDetalle(entradaDetalle, tipoTransaccion);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}