using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;
using POS.Admin.Identities;
using System.IO;

namespace POS.Admin.Appl
{
    public partial class UCSeguridad : UserControl
    {
        #region Variables

        private SeguridadBL seguridadBL;
        private RespaldosBL respaldosBL;

        #endregion Variables

        public UCSeguridad()
        {
            InitializeComponent();
        }

        private void UCSeguridad_Load(object sender, EventArgs e)
        {

        }

        #region Seguridad

        public void aplicaPoliticas()
        {
            seguridadBL = new SeguridadBL();
            respaldosBL = new RespaldosBL();

            cbRespaldos.Items.Clear();
            foreach (DataRow row in Globales.tablaSucursales.Rows)
            {
                cbRespaldos.Items.Add(row["nombre"]);
            }


            foreach (DataRow row in Globales.tablaAccesos.Rows)
            {
                switch (row["modulo"].ToString())
                {
                    case "SEGURIDAD":
                        if (Convert.ToBoolean(row["agregar"]))
                        {
                            BTNuevoRol.Enabled = true;
                            BTNuevoUsuario.Enabled = true;
                            BTAsignaPolitica.Enabled = true;
                        }
                        else
                        {
                            BTNuevoRol.Enabled = false;
                            BTNuevoUsuario.Enabled = false;
                            BTAsignaPolitica.Enabled = false;
                        }
                        if (Convert.ToBoolean(row["eliminar"]))
                        {
                            BTEliminaRol.Enabled = true;
                            BTEliminaUsuario.Enabled = true;
                            BTEliminaPolitica.Enabled = true;
                        }
                        else
                        {
                            BTEliminaRol.Enabled = false;
                            BTEliminaUsuario.Enabled = false;
                            BTEliminaPolitica.Enabled = false;
                        }
                        if (Convert.ToBoolean(row["visualizar"]))
                        {
                            BTCargaRol.Enabled = true;
                            BTCargaUsuario.Enabled = true;
                            BTCargaModulo.Enabled = true;
                            BTCargarPolitica.Enabled = true;
                        }
                        else
                        {
                            BTCargaRol.Enabled = false;
                            BTCargaUsuario.Enabled = false;
                            BTCargaModulo.Enabled = false;
                            BTCargarPolitica.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void BTCargaRol_Click(object sender, EventArgs e)
        {
            cargaRoles();
        }

        private void cargaRoles()
        {
            try
            {
                Globales.tablaRoles = seguridadBL.getRoles(Globales.empresaId);
                gridRoles.DataSource = Globales.tablaRoles;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaRol_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaRol();

                if (MessageBox.Show("Desea Eliminar el Rol con ID: " + Globales.rolID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaRol(Globales.rolID));
                    cargaRoles();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaRol()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridRoles.CurrentRow.Index);
                Globales.rolID = int.Parse(gridRoles.Rows[posicion_list].Cells[0].Value.ToString());
                Globales.rol = gridRoles.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNuevoRol_Click(object sender, EventArgs e)
        {
            EdicionRol edicionRol = new EdicionRol(seguridadBL);
            edicionRol.ShowDialog();
            cargaRoles();
        }

        private void BTCargaUsuario_Click(object sender, EventArgs e)
        {
            cargaUsuarios();
        }

        private void cargaUsuarios()
        {
            try
            {
                DataTable table = seguridadBL.getUsuarios(Globales.empresaId);
                gridUsuarios.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaUsuario();

                if (MessageBox.Show("Desea Eliminar al Usuario con ID: " + Globales.usuarioID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaUsuario(Globales.usuarioID));
                    cargaUsuarios();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaUsuario()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridUsuarios.CurrentRow.Index);
                Globales.usuarioID = int.Parse(gridUsuarios.Rows[posicion_list].Cells[0].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTCargaModulo_Click(object sender, EventArgs e)
        {
            cargaModulos();
        }

        private void BTNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (Globales.tablaRoles.Rows.Count <= 0)
                Globales.tablaRoles = seguridadBL.getRoles(Globales.empresaId);
            EdicionUsuario edicionUsuario = new EdicionUsuario(seguridadBL, Globales.tablaRoles);
            edicionUsuario.ShowDialog();
            cargaUsuarios();
        }

        private void cargaModulos()
        {
            try
            {
                DataTable table = seguridadBL.getModulos();
                gridModulos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTCargarPolitica_Click(object sender, EventArgs e)
        {
            cargaPoliticas();
        }

        private void cargaPoliticas()
        {
            try
            {
                seleccionaRol();
                DataTable table = seguridadBL.getPoliticas(Globales.rolID);
                gridPoliticas.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTEliminaPolitica_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionaPolitica();

                if (MessageBox.Show("Desea Eliminar la Politica con ID: " + Globales.usuarioID + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show(seguridadBL.eliminaPolitica(Globales.politicaID));
                    cargaPoliticas();
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionaPolitica()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridPoliticas.CurrentRow.Index);
                Globales.politicaID = int.Parse(gridPoliticas.Rows[posicion_list].Cells[0].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTAsignaPolitica_Click(object sender, EventArgs e)
        {
            seleccionaRol();
            seleccionaModulo();
            EdicionPolitica edicionPolitica = new EdicionPolitica(seguridadBL, Globales.rolID, Globales.moduloID, Globales.rol, Globales.modulo);
            edicionPolitica.ShowDialog();
            cargaPoliticas();
        }

        private void seleccionaModulo()
        {
            try
            {
                int posicion_list = Convert.ToInt32(gridModulos.CurrentRow.Index);
                Globales.moduloID = int.Parse(gridModulos.Rows[posicion_list].Cells[0].Value.ToString());
                Globales.modulo = gridModulos.Rows[posicion_list].Cells[1].Value.ToString();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Seguridad

        #region Respaldos

        private void cbBuscaRespaldo_Click(object sender, EventArgs e)
        {
            cargaRespaldos();
        }

        private void cargaRespaldos()
        {
            try
            {
                string sucursalID = string.Empty;

                foreach (DataRow row in Globales.tablaSucursales.Rows)
                {
                    if (row["nombre"].Equals(cbRespaldos.Text.Trim()))
                    {
                        sucursalID = row["sucursalID"].ToString();
                        break;
                    }
                }

                DataTable table = respaldosBL.getRespaldos(sucursalID);
                gridRespaldos.DataSource = table;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Respaldos
    }
}
