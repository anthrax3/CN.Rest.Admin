using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using utils = POS.Utilities.Utils;

namespace POS.Admin.Appl
{
    public partial class OrdenesTerminal : Form
    {
        public OrdenesTerminal()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void OrdenesTerminal_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            listOrdenes.Items.Clear();

            string[] archivos = Directory.GetFiles(utils.getPathTerminal().Trim(), "PEDIDO*.xml");

            foreach (string archivo in archivos)
            {
                listOrdenes.Items.Add(archivo.Trim().Replace(utils.getPathTerminal().Trim(),""));
            }

        }

        private void BTRefrescar_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}