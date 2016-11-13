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
    public partial class EdicionArticulo : Form
    {
        private ArticulosBL articulosBL;
        private Articulos articulos;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionArticulo(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionArticulo(Objetos.TipoTransaccion _tipoTransaccion, Articulos _articulos)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            articulos = _articulos;
        }

        private void inicializa()
        {
            InitializeComponent();
            articulos = new Articulos();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbGrupo.Text.Trim()))
            {
                articulos.ean = txtEan.Text.Trim();
                articulos.descripcion = txtDescripcion.Text.Trim();
                articulos.medida = txtMedida.Text.Trim();
                articulos.costo = txtCosto.Text.Trim();
                articulos.venta = txtVenta.Text.Trim();
                articulos.iva = CBImpuesto.Text.Trim();
                articulos.estatus = CBEstatus.Text.Trim();
                articulos.unidad = CBUnidad.Text.Trim();
                articulos.grupo = cbGrupo.Text.Trim();

                articulosBL = new ArticulosBL();
                MessageBox.Show(articulosBL.setArticulos(articulos, tipoTransaccion, Globales.empresaId));
            }
            else
                MessageBox.Show("Favor de seleccionar un Grupo valido");
        }

        private void EdicionArticulo_Load(object sender, EventArgs e)
        {
            CBEstatus.Items.AddRange(Globales.estatus.ToArray());
            foreach (DataRow row in Globales.tablaImpuestos.Rows)
                CBImpuesto.Items.Add(row["porcentaje"].ToString());
            foreach (DataRow row in Globales.tablaUnidades.Rows)
                CBUnidad.Items.Add(row["descripcion"].ToString());
            foreach (DataRow row in Globales.tablaSubCategorias.Rows)
                CBSubCategoria.Items.Add(row["descripcion"].ToString());

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtEan.Text = articulos.ean;
                txtDescripcion.Text = articulos.descripcion;
                txtMedida.Text = articulos.medida;
                txtCosto.Text = articulos.costo;
                txtVenta.Text = articulos.venta;
                CBImpuesto.Text = articulos.iva;
                CBEstatus.Text = articulos.estatus;
                CBUnidad.Text = articulos.unidad;
                CBSubCategoria.Text = articulos.subcategoria;
                cbGrupo.Text = articulos.grupo;
                toolStripModificaCodigo.Enabled = true;
            }
            else
                toolStripModificaCodigo.Enabled = false;
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

        private void toolStripModificaCodigo_Click(object sender, EventArgs e)
        {
            NuevoCodigoEAN nuevoCodigo = new NuevoCodigoEAN(articulos.ean);
            nuevoCodigo.ShowDialog();

            if (! String.IsNullOrEmpty(nuevoCodigo.NuevoEAN))
            {
                txtEan.Text = nuevoCodigo.NuevoEAN;
                articulos.ean = nuevoCodigo.NuevoEAN;
            }
        }

        private void CBSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] foundRows;
            foundRows = Globales.tablaSubCategorias.Select("descripcion = '" + CBSubCategoria.Text.Trim() + "'");
            CatalogosTemp.getGrupos(foundRows[0].ItemArray[0].ToString());

            cbGrupo.Text = "";
            cbGrupo.Items.Clear();
            foreach (DataRow row in Globales.tablaGrupos.Rows)
                cbGrupo.Items.Add(row["descripcion"].ToString());
        }
    }
}