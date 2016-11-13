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
    public partial class EdicionSubcategoria : Form
    {
        private CategoriasBL categoriasBL;
        private SubCategorias subCategorias;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionSubcategoria(Objetos.TipoTransaccion _tipoTransaccion, string _categoriaID)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            subCategorias.categoriaID = _categoriaID;
        }

        public EdicionSubcategoria(Objetos.TipoTransaccion _tipoTransaccion, SubCategorias _subCategorias)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            subCategorias = _subCategorias;
        }

        private void inicializa()
        {
            InitializeComponent();
            subCategorias = new SubCategorias();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            subCategorias.descripcion = txtDescripcion.Text;
            subCategorias.categoriaID = txtCategoriaID.Text;

            categoriasBL = new CategoriasBL();
            MessageBox.Show(categoriasBL.setSubCategorias(subCategorias, tipoTransaccion));
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionSubcategoria_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subCategorias.categoriaID))
            {
                toolStripGuardar.Enabled = false;
                MessageBox.Show("Error, Favor de seleccionar una Categoria");
            }
            else
            {
                toolStripGuardar.Enabled = true;
                txtCategoriaID.Text = subCategorias.categoriaID;

                if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
                {
                    txtDescripcion.Text = subCategorias.descripcion;
                }
            }
        }
    }
}