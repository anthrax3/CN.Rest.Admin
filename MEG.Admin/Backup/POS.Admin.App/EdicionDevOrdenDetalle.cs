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
    public partial class EdicionDevOrdenDetalle : Form
    {
        private devolucionOrdenDetalle DevolucionOrdenDetalle;
        private DevolucionOrdenBL devolucionOrdenBL;
        private ArticulosBL articulosBL;
        private Objetos.TipoTransaccion tipoTransaccion;
        private string devolucionOrdenID;
        private string articuloID = string.Empty;
        private decimal _iva = 0;

        public EdicionDevOrdenDetalle(Objetos.TipoTransaccion _tipoTransaccion, string _devolucionOrdenID)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            devolucionOrdenID = _devolucionOrdenID;
        }

        public EdicionDevOrdenDetalle(Objetos.TipoTransaccion _tipoTransaccion, devolucionOrdenDetalle _DevolucionOrdenDetalle)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            DevolucionOrdenDetalle = _DevolucionOrdenDetalle;
        }

        private void inicializa()
        {
            InitializeComponent();
            DevolucionOrdenDetalle = new devolucionOrdenDetalle();
            devolucionOrdenBL = new DevolucionOrdenBL();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            try
            {
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
                        txtSubtotal.Text = "0";
                        _iva = Convert.ToDecimal(row["iva"]);
                        txtIva.Text = "0";
                        txtTotal.Text = "0";
                    }
                }
                else
                    limpiaCampos();
            }
        }

        private void EdicionDevOrdenDetalle_Load(object sender, EventArgs e)
        {
            radioDescripcion.Checked = true;

            txtEan.Text = DevolucionOrdenDetalle.ean;
            txtDescripcion.Text = DevolucionOrdenDetalle.descripcion;
            txtCantidad.Text = DevolucionOrdenDetalle.cantidad;
            txtCosto.Text = DevolucionOrdenDetalle.costo;
            txtVenta.Text = DevolucionOrdenDetalle.venta;
            txtSubtotal.Text = DevolucionOrdenDetalle.subtotal;
            txtIva.Text = DevolucionOrdenDetalle.iva;
            txtTotal.Text = DevolucionOrdenDetalle.total;
            if (DevolucionOrdenDetalle.porcentaje_iva.Length > 0)
                _iva = Convert.ToDecimal(DevolucionOrdenDetalle.porcentaje_iva);

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtEan.Enabled = false;
                groupBusqueda.Enabled = false;
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
            txtSubtotal.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";
        }

        private void calculaPartida()
        {
            try
            {
                if ((txtCosto.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
                {
                    decimal costo = Convert.ToDecimal(txtCosto.Text);
                    decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
                    decimal subtotal = 0;
                    decimal iva = _iva;
                    decimal total = 0;
                    devolucionOrdenBL.calculaPartida(costo, cantidad, ref subtotal, ref iva, ref total);

                    txtSubtotal.Text = Convert.ToString(subtotal);
                    txtIva.Text = Convert.ToString(iva);
                    txtTotal.Text = Convert.ToString(total);
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            calculaPartida();
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
            calculaPartida();
        }

        private void gridBusqueda_DoubleClick(object sender, EventArgs e)
        {
            limpiaCampos();
            lblMensaje.Text = "";
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
                limpiaCampos();
                lblMensaje.Text = "";
                txtEan.Text = obtieneDetalle(true);
                txtEan.SelectAll();
                txtEan.Focus();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DevolucionOrdenDetalle.ean = txtEan.Text;
            DevolucionOrdenDetalle.descripcion = txtDescripcion.Text;
            DevolucionOrdenDetalle.cantidad = txtCantidad.Text;
            DevolucionOrdenDetalle.costo = txtCosto.Text;
            DevolucionOrdenDetalle.venta = txtVenta.Text;
            DevolucionOrdenDetalle.subtotal = txtSubtotal.Text;
            DevolucionOrdenDetalle.iva = txtIva.Text;
            DevolucionOrdenDetalle.total = txtTotal.Text;

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.INSERT))
            {
                DevolucionOrdenDetalle.devolucionOrdenID = devolucionOrdenID;
                DevolucionOrdenDetalle.id = articuloID;
            }

            lblMensaje.Text = devolucionOrdenBL.setDevOrdenDetalle(DevolucionOrdenDetalle, tipoTransaccion);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}