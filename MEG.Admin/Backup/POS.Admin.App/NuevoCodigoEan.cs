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
    public partial class NuevoCodigoEAN : Form
    {
        private ArticulosBL articulosBL;

        private string _NuevoEAN;

        public string NuevoEAN
        {
            get { return _NuevoEAN; }
        }


        public NuevoCodigoEAN(string _ean)
        {
            InitializeComponent();
            txtEan.Text = _ean.Trim();
        }

        private void NuevoCodigoEAN_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            _NuevoEAN = string.Empty;
            articulosBL = new ArticulosBL();
            if (articulosBL.setNuevoCodigo(txtEan.Text, txtNuevo.Text.Trim(), Globales.empresaId) > 0)
            {
                _NuevoEAN = txtNuevo.Text.Trim();
                MessageBox.Show("Nuevo Código Afectado correctamente");
                this.Hide();
                this.Close();
            }
            else
                MessageBox.Show("No pudo ser afectado el Nuevo Código");
        }
    }
}