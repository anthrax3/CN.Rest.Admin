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
    public partial class EdicionMesa : Form
    {
        private Mesas mesas;
        private MesasBL mesasBL;
        public DataTable tableSucursales;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionMesa(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionMesa(Mesas _mesas, Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            mesas = _mesas;
            tipoTransaccion = _tipoTransaccion;
        }

        private void inicializa()
        {
            InitializeComponent();
            mesasBL = new MesasBL();
            mesas = new Mesas();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            mesas.nombre = txtNombre.Text.Trim();
            mesas.numero = txtNumero.Text.Trim();

            DataRow[] foundRows;
            foundRows = tableSucursales.Select("nombre = '" + CBSucursal.Text.Trim() + "'");
            mesas.sucursalID = foundRows[0].ItemArray[0].ToString();

            MessageBox.Show(mesasBL.setMesas(mesas, tipoTransaccion));
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionMesa_Load(object sender, EventArgs e)
        {
            listarSucursales();

            if (tipoTransaccion == Objetos.TipoTransaccion.UPDATE)
            {
                txtNombre.Text = mesas.nombre;
                txtNumero.Text = mesas.numero;
                CBSucursal.Text = mesas.sucursalID;
            }

        }

        private void listarSucursales()
        {
            try
            {
                CBSucursal.Items.Clear();
                foreach (DataRow row in tableSucursales.Rows)
                {
                    CBSucursal.Items.Add(row["nombre"].ToString());
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}