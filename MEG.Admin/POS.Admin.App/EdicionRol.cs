using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;

namespace POS.Admin.Appl
{
    public partial class EdicionRol : Form
    {
        private SeguridadBL seguridadBL;

        public EdicionRol(SeguridadBL _seguridadBL)
        {
            InitializeComponent();
            seguridadBL = _seguridadBL;
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                if (seguridadBL.insertaRol(txtDescripcion.Text, Globales.empresaId) > 0)
                {
                    MessageBox.Show("El nuevo rol ha sido agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salir();
                }
                else
                    MessageBox.Show("No se pudo insertar el nuevo registro, probablemente ya existe un rol con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Favor de agregar un texto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void salir()
        {
            this.Hide();
            this.Close();
        }

        private void EdicionRol_Load(object sender, EventArgs e)
        {

        }
    }
}