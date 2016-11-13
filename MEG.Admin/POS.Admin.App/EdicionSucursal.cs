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
    public partial class EdicionSucursal : Form
    {
        private SucursalesBL sucursalesBL;
        private Sucursales sucursales;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionSucursal(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionSucursal(Objetos.TipoTransaccion _tipoTransaccion, Sucursales _sucursales)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            sucursales = _sucursales;
        }

        private void inicializa()
        {
            InitializeComponent();
            sucursales = new Sucursales();
        }

        private void EdicionSucursal_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            foreach (DataRow row in Globales.tablaEstados.Rows)
            {
                cbEstado.Items.Add(row["descripcion"].ToString());
            }

            cbImpuesto.Items.Clear();
            foreach (DataRow row in Globales.tablaImpuestos.Rows)
            {
                cbImpuesto.Items.Add(row["porcentaje"].ToString());
            }

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtNombre.Text = sucursales.nombre;
                //txtCodigo.Text = sucursales.codigo;
                txtRfc.Text = sucursales.rfc;
                txtCalle.Text = sucursales.calle;
                txtRazonSocial.Text = sucursales.razon_social;
                txtExterior.Text = sucursales.noExt;
                txtInterior.Text = sucursales.noInt;
                txtColonia.Text = sucursales.colonia;
                txtCp.Text = sucursales.cp;
                cbEstado.Text = sucursales.estadoID;
                cbMunicipio.Text = sucursales.municipioID;
                txtTelefono.Text  = sucursales.telefono;
                txtPie.Text  = sucursales.pie;
                cbImpuesto.Text = sucursales.impuestoID;
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            sucursales.nombre = txtNombre.Text.Trim();
            sucursales.cp = txtCp.Text.Trim();
            sucursales.rfc = txtRfc.Text;
            sucursales.calle = txtCalle.Text;
            sucursales.razon_social = txtRazonSocial.Text;
            sucursales.noExt = txtExterior.Text;
            sucursales.noInt = txtInterior.Text;
            sucursales.colonia = txtColonia.Text;
            sucursales.estadoID =  cbEstado.Text;
            sucursales.telefono = txtTelefono.Text;
            sucursales.pie = txtPie.Text;

            DataRow[] foundRows;
            foundRows = Globales.tablaMunicipios.Select("descripcion = '" + cbMunicipio.Text.Trim() + "'");
            sucursales.municipioID = foundRows[0].ItemArray[0].ToString();
            foundRows = Globales.tablaImpuestos.Select("porcentaje = '" + cbImpuesto.Text.Trim() + "'");
            sucursales.impuestoID = foundRows[0].ItemArray[0].ToString();

            sucursalesBL = new SucursalesBL();
            MessageBox.Show(sucursalesBL.setSucursales(sucursales, tipoTransaccion, Globales.empresaId));
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}