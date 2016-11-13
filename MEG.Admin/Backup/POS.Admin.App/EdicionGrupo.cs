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
    public partial class EdicionGrupo : Form
    {
        private CategoriasBL categoriasBL;
        private Grupos grupos;
        private Objetos.TipoTransaccion tipoTransaccion;

        public EdicionGrupo(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionGrupo(Objetos.TipoTransaccion _tipoTransaccion, Grupos _grupos)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            grupos = _grupos;
        }

        private void inicializa()
        {
            InitializeComponent();
            grupos = new Grupos();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows;
            foundRows = Globales.tablaSubCategorias.Select("descripcion = '" +cbSubCategoria.Text.Trim() + "'");

            grupos.descripcion = txtDescripcion.Text;
            grupos.subcategoriaId = foundRows[0].ItemArray[0].ToString();

            categoriasBL = new CategoriasBL();
            MessageBox.Show(categoriasBL.setGrupos(grupos, tipoTransaccion));
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionSubcategoria_Load(object sender, EventArgs e)
        {
            listarSubCategorias();

            if (tipoTransaccion == Objetos.TipoTransaccion.UPDATE)
            {
                toolStripGuardar.Enabled = true;

                DataRow[] foundRows;
                foundRows = Globales.tablaSubCategorias.Select("subCategoriaID = '" + grupos.subcategoriaId + "'");

                cbSubCategoria.Text = foundRows[0].ItemArray[1].ToString();
                txtDescripcion.Text = grupos.descripcion;
            }
        }

        private void listarSubCategorias()
        {
            try
            {
                cbSubCategoria.Items.Clear();
                foreach (DataRow row in Globales.tablaSubCategorias.Rows)
                {
                    cbSubCategoria.Items.Add(row["descripcion"].ToString());
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}