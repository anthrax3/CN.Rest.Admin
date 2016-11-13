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
    public partial class EdicionUnidades : Form
    {
        private DataTable _tablaUnidades;
        public DataTable tablaUnidades
        {
            get { return _tablaUnidades; }
            set { _tablaUnidades = value; }
        }

        public EdicionUnidades()
        {
            InitializeComponent();
        }


        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionUnidades_Load(object sender, EventArgs e)
        {
            listUnidades.Items.Clear();
            int x = 0;
            foreach (DataRow Row in _tablaUnidades.Rows)
            {
                listUnidades.Items.Add(Row["unidadID"].ToString());
                listUnidades.Items[x].SubItems.Add(Row["descripcion"].ToString());
                listUnidades.Items[x].SubItems.Add(Row["abreviatura"].ToString());
                x++;
            }
        }
    }
}