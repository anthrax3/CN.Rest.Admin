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
    public partial class EdicionPolitica : Form
    {
        private SeguridadBL seguridadBL;
        private int rolID;
        private int moduloID;

        public EdicionPolitica(SeguridadBL _seguridadBL, int _rolID, int _moduloID, string _rol, string _modulo)
        {
            InitializeComponent();
            seguridadBL = _seguridadBL;
            rolID = _rolID;
            moduloID = _moduloID;
            lblRol.Text = _rol;
            lblModulo.Text = _modulo;
        }

        private void EdicionPolitica_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void salir()
        {
            this.Hide();
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (seguridadBL.insertaPolitica(rolID, moduloID, Convert.ToInt32(CHBAgregar.Checked), Convert.ToInt32(CHBModificar.Checked),
                Convert.ToInt32(CHBEliminar.Checked), Convert.ToInt32(CHBVisualizar.Checked)) > 0)
            {
                MessageBox.Show("La nueva política ha sido agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salir();
            }
            else
                MessageBox.Show("No se pudo insertar el nuevo registro, probablemente ya existe una política identica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}