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
    public partial class EdicionCategoria : Form
    {
        private CategoriasBL categoriasBL;
        private Categorias categorias;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionCategoria(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionCategoria(Objetos.TipoTransaccion _tipoTransaccion, Categorias _categorias)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            categorias = _categorias;
        }

        private void inicializa()
        {
            InitializeComponent();
            categorias = new Categorias();
        }

        private void EdicionCategoria_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtDescripcion.Text = categorias.descripcion;
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            categorias.descripcion = txtDescripcion.Text;

            categoriasBL = new CategoriasBL();
            MessageBox.Show(categoriasBL.setCategorias(categorias, tipoTransaccion, Globales.empresaId));
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}