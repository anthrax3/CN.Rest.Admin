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
    public partial class EdicionCliente : Form
    {
        private ClientesBL clientesBL;
        private Clientes clientes;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionCliente(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionCliente(Objetos.TipoTransaccion _tipoTransaccion, Clientes _clientes)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            clientes = _clientes;
        }

        private void inicializa()
        {
            InitializeComponent();
            clientes = new Clientes();
        }

        private void EdicionCliente_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            foreach (DataRow row in Globales.tablaEstados.Rows)
            {
                cbEstado.Items.Add(row["descripcion"].ToString());
            }

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtRfc.Text = clientes.rfc;
                txtRazon.Text = clientes.razonSocial;
                txtNombreComercial.Text = clientes.nombreComercial;
                txtCalle.Text = clientes.calle;
                txtExterior.Text = clientes.noExt;
                txtInterior.Text = clientes.noInt;
                txtColonia.Text = clientes.colonia;
                txtCodigo.Text = clientes.cp;
                cbEstado.Text = clientes.estadoID;
                cbMunicipio.Text = clientes.municipioID;
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtCodigo.Text);

                clientes.rfc = txtRfc.Text.Trim();
                clientes.razonSocial = txtRazon.Text.Trim();
                clientes.nombreComercial = txtNombreComercial.Text;
                clientes.calle = txtCalle.Text;
                clientes.noExt = txtExterior.Text;
                clientes.noInt = txtInterior.Text;
                clientes.colonia = txtColonia.Text;
                clientes.cp = txtCodigo.Text;
                DataRow[] foundRows;
                foundRows = Globales.tablaMunicipios.Select("descripcion = '" + cbMunicipio.Text.Trim() + "'");
                clientes.municipioID = foundRows[0].ItemArray[0].ToString();

                clientesBL = new ClientesBL();
                MessageBox.Show(clientesBL.setClientes(clientes, ref tipoTransaccion, Globales.empresaId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbMunicipio.Text = "";

                DataRow[] foundRows;
                foundRows = Globales.tablaEstados.Select("descripcion = '" + cbEstado.Text.Trim() + "'");

                DataRow[] foundRowsEst;
                foundRowsEst = Globales.tablaMunicipios.Select("estadoID = '" + foundRows[0].ItemArray[0].ToString() + "'");

                cbMunicipio.Items.Clear();
                foreach (DataRow row in foundRowsEst)
                {
                    cbMunicipio.Items.Add(row["descripcion"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}