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
    public partial class Acceso : Form
    {
        SeguridadBL seguridadBL;
        public bool status = false;

        public Acceso(SeguridadBL _seguridadBL)
        {
            InitializeComponent();
            seguridadBL = _seguridadBL;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void salir()
        {
            this.Hide();
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    Globales.tablaAccesos = new DataTable();
                    Globales.tablaAccesos = seguridadBL.validaCuenta(txtUsuario.Text, txtPassword.Text, "0123456789");

                    if (Globales.tablaAccesos.Rows.Count > 0)
                    {
                        if (Globales.tablaAccesos.Rows[0].ItemArray.GetValue(0).ToString().Trim().Length > 0)
                        {
                            //MessageBox.Show("Cuenta correcta", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            status = true;
                            salir();
                        }
                        else
                            MessageBox.Show("Cuenta de usuario incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Cuenta de usuario incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            //System.Environment.SetEnvironmentVariable("hola", "caca", EnvironmentVariableTarget.Machine);
            //MessageBox.Show(System.Environment.GetEnvironmentVariable("hola", EnvironmentVariableTarget.Machine));
        }
    }
}