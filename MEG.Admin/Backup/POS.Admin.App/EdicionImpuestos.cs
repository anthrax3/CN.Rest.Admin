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
    public partial class EdicionImpuestos : Form
    {
        private DataTable _tablaImpuestos;
        public DataTable tablaImpuestos
        {
            get { return _tablaImpuestos; }
            set { _tablaImpuestos = value; }
        }

        public EdicionImpuestos()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionImpuestos_Load(object sender, EventArgs e)
        {
            listImpuestos.Items.Clear();
            int x = 0;
            foreach (DataRow Row in _tablaImpuestos.Rows)
            {
                listImpuestos.Items.Add(Row["impuestoID"].ToString());
                listImpuestos.Items[x].SubItems.Add(Row["descripcion"].ToString());
                listImpuestos.Items[x].SubItems.Add(Row["porcentaje"].ToString());
                listImpuestos.Items[x].SubItems.Add(Row["tipo"].ToString());
                x++;
            }
        }
    }
}