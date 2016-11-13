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
    public partial class EdicionUsuario : Form
    {
        private SeguridadBL seguridadBL;
        DataTable tablaRoles;

        public EdicionUsuario(SeguridadBL _seguridadBL, DataTable _tablaRoles)
        {
            InitializeComponent();
            seguridadBL = _seguridadBL;
            tablaRoles = _tablaRoles;
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
            string rolID = string.Empty;

            if (!string.IsNullOrEmpty(txtUsuario.Text.Trim()) && !string.IsNullOrEmpty(CBRoles.Text.Trim()))
            {
                if ((string.Equals(txtPassword.Text.Trim(), txtConfirmar.Text.Trim())) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    foreach (DataRow row in tablaRoles.Rows)
                    {
                        if (row["descripcion"].Equals(CBRoles.Text.Trim()))
                        {
                            rolID = row["rolID"].ToString();
                            break;
                        }
                    }

                    if (seguridadBL.insertaUsuario(txtUsuario.Text, txtPassword.Text, rolID, Globales.empresaId, txtNombre.Text, txtPaterno.Text, txtMaterno.Text) > 0)
                    {
                        MessageBox.Show("El nuevo Usuario ha sido agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                        MessageBox.Show("No se pudo insertar el nuevo registro, probablemente ya existe un usuario con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Las contraseñas no son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Favor de agregar un texto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EdicionUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in tablaRoles.Rows)
                CBRoles.Items.Add(row["descripcion"]);
        }

        private void GBCaptura_Enter(object sender, EventArgs e)
        {

        }
    }
}