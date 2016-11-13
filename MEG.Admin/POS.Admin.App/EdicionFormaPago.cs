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
    public partial class EdicionFormaPago : Form
    {
        private FormasPagoBL formasPagoBL;
        private FormasPago formasPago;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionFormaPago(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionFormaPago(Objetos.TipoTransaccion _tipoTransaccion, FormasPago _formasPago)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            formasPago = _formasPago;
        }

        private void inicializa()
        {
            InitializeComponent();
            formasPago = new FormasPago();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            formasPago.descripcion = txtDescripcion.Text.Trim();
            formasPago.estatus = CBEstatus.Text.Trim();
            formasPago.credito = chbCliente.Checked;
            formasPago.principal = (cbPrincipal.Text == "SI") ?  1 : 0;

            formasPagoBL = new FormasPagoBL();
            MessageBox.Show(formasPagoBL.setPagos(formasPago, ref tipoTransaccion, Globales.empresaId));
        }

        private void EdicionFormaPago_Load(object sender, EventArgs e)
        {
            CBEstatus.Items.AddRange(Globales.estatus.ToArray());

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtDescripcion.Text = formasPago.descripcion;
                CBEstatus.Text = formasPago.estatus;
                chbCliente.Checked = formasPago.credito;
                cbPrincipal.Text = (formasPago.principal == 1) ? "SI" : "NO";
            }
        }
    }
}