using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.Admin.Appl
{
    public partial class ConsultaInvSucursal : Form
    {
        private DateTime _fechaDe;

        public DateTime fechaDe
        {
            get { return _fechaDe; }
            set { _fechaDe = value; }
        }

        private DateTime _fechaA;

        public DateTime fechaA
        {
            get { return _fechaA; }
            set { _fechaA = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public ConsultaInvSucursal()
        {
            InitializeComponent();

            _tipo = string.Empty;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            _fechaDe = dtpDe.Value;
            _fechaA = dtpA.Value;

            if (string.IsNullOrEmpty(listTipo.Text.Trim()))
                MessageBox.Show("Seleccione el tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                _tipo = listTipo.Text.Trim();
                this.Hide();
                this.Close();
            }
        }

        private void ConsultaInvSucursal_Load(object sender, EventArgs e)
        {

        }
    }
}