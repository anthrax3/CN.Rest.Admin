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
    public partial class EdicionProveedor : Form
    {
        private ProveedorBL proveedorBL;
        private Proveedores proveedores;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionProveedor(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionProveedor(Objetos.TipoTransaccion _tipoTransaccion, Proveedores _proveedores)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            proveedores = _proveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            proveedores = new Proveedores();
        }

        private void EdicionProveedor_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtRfc.Text = proveedores.rfc;
                txtRazon.Text = proveedores.razon;
                txtDireccion.Text = proveedores.direccion;
                chbAlmacen.Checked = proveedores.almacen;
                txtAlias.Text = proveedores.alias;
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            proveedores.rfc = txtRfc.Text.Trim();
            proveedores.razon = txtRazon.Text.Trim();
            proveedores.direccion = txtDireccion.Text.Trim();
            proveedores.almacen = chbAlmacen.Checked;
            proveedores.alias = txtAlias.Text;

            proveedorBL = new ProveedorBL();
            MessageBox.Show(proveedorBL.setProveedores(proveedores, ref tipoTransaccion, Globales.empresaId));
        }
    }
}