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
    public partial class EdicionPaquetes : Form
    {
        private PaquetesBL paquetesBL;
        private ArticulosBL articulosBL;
        private Objetos.TipoTransaccion tipoTransaccion;
        private Paquetes paquetes;
        private DataTable tablaProductos;

        public EdicionPaquetes(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionPaquetes(Paquetes _paquetes, Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            paquetes = _paquetes;
        }

        private void inicializa()
        {
            InitializeComponent();
            paquetesBL = new PaquetesBL();
            paquetes = new Paquetes();
            articulosBL = new ArticulosBL();
            tablaProductos = new DataTable();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionPaquetes_Load(object sender, EventArgs e)
        {
            cargaListas();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtDescripcion.Text = paquetes.descripcion;
                txtPrecioVenta.Text = paquetes.precioVenta;
                txtNoArticulos.Text = paquetes.noArticulos;
                CBCategorias.Text = paquetes.categoria;
                CBEstatus.Text = paquetes.estatus;
                CBSucursal.Text = paquetes.sucursal;
                dtInicio.Text = paquetes.horaInicio;
                dtFin.Text = paquetes.horaFin;
                txtConsumo.Text = paquetes.consumo;

                GridArticulos.Rows.Clear();
                foreach (DataRow row in paquetesBL.getPaquetesArticulos(paquetes.id).Rows)
                    GridArticulos.Rows.Add(row.ItemArray);

                gridSubCategorias.Rows.Clear();
                foreach (DataRow row in paquetesBL.getPaquetesSubCategorias(paquetes.id).Rows)
                    gridSubCategorias.Rows.Add(row.ItemArray);
            }
        }

        private void cargaListas()
        {
            CBSucursal.Items.Clear();
            CBCategorias.Items.Clear();
            CBSubCategoria.Items.Clear();
            CBCategoriaArt.Items.Clear();

            CBSucursal.Text = "";
            CBCategorias.Text = "";
            CBSubCategoria.Text = "";
            CBCategoriaArt.Text = "";

            foreach (DataRow row in Globales.tablaSubCategorias.Rows)
            {
                CBSubCategoria.Items.Add(row["descripcion"].ToString());
                CBCategoriaArt.Items.Add(row["descripcion"].ToString());
            }

            foreach (DataRow row in Globales.tablaCategorias.Rows)
            {
                CBCategorias.Items.Add(row["descripcion"].ToString());
            }
            
            foreach (DataRow row in Globales.tablaSucursales.Rows)
            {
                CBSucursal.Items.Add(row["nombre"].ToString());
            }

            CBEstatus.Items.Clear();
            CBEstatus.Items.AddRange(Globales.estatus.ToArray());
        }

        private void CBCategoriaArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] foundRows;
            foundRows = Globales.tablaSubCategorias.Select("descripcion = '" + CBCategoriaArt.Text.Trim() + "'");
            tablaProductos = articulosBL.getArticulosSubCat(foundRows[0].ItemArray[0].ToString());
            CBArticulo.Items.Clear();
            CBArticulo.Text = "";
            foreach (DataRow row in tablaProductos.Rows)
            {
                CBArticulo.Items.Add(row["descripcion"].ToString());
            }
        }

        private void btAgregaSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] foundRows;
                foundRows = Globales.tablaSubCategorias.Select("descripcion = '" + CBSubCategoria.Text.Trim() + "'");
                gridSubCategorias.Rows.Add(foundRows[0].ItemArray);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void btAgregaArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] foundRows;
                foundRows = tablaProductos.Select("descripcion = '" + CBArticulo.Text.Trim() + "'");
                GridArticulos.Rows.Add(foundRows[0].ItemArray);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                paquetes.descripcion = txtDescripcion.Text.Trim();
                paquetes.precioVenta = txtPrecioVenta.Text.Trim();
                paquetes.estatus = CBEstatus.Text.Trim();
                paquetes.horaInicio = dtInicio.Text;
                paquetes.horaFin = dtFin.Text;
                paquetes.consumo = txtConsumo.Text;

                DataRow[] foundRows;
                foundRows = Globales.tablaCategorias.Select("descripcion = '" + CBCategorias.Text.Trim() + "'");
                paquetes.categoria = foundRows[0].ItemArray[0].ToString();

                foundRows = Globales.tablaSucursales.Select("nombre = '" + CBSucursal.Text.Trim() + "'");
                paquetes.sucursal = foundRows[0].ItemArray[0].ToString();

                paquetes.noArticulos = txtNoArticulos.Text;
                paquetes.paqueteArticulo = new List<PaqueteArticulo>();
                paquetes.paqueteMezcladores = new List<PaqueteMezcladores>();
                PaqueteArticulo paqueteArticulo = new PaqueteArticulo();
                PaqueteMezcladores paqueteMezcladores = new PaqueteMezcladores();

                foreach (DataGridViewRow row in GridArticulos.Rows)
                {
                    paqueteArticulo = new PaqueteArticulo();
                    paqueteArticulo.codigoArticulo = row.Cells[0].Value.ToString();
                    paquetes.paqueteArticulo.Add(paqueteArticulo);
                }

                foreach (DataGridViewRow row in gridSubCategorias.Rows)
                {
                    paqueteMezcladores = new PaqueteMezcladores();
                    paqueteMezcladores.subCategoriaID = row.Cells[0].Value.ToString();
                    paqueteMezcladores.cantidad = (string.IsNullOrEmpty(row.Cells[2].FormattedValue.ToString())) ? "1" : row.Cells[2].FormattedValue.ToString();
                    paquetes.paqueteMezcladores.Add(paqueteMezcladores);
                }

                MessageBox.Show(paquetesBL.setPaquetes(paquetes, tipoTransaccion, Globales.empresaId));
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void gridSubCategorias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal x = Convert.ToDecimal(gridSubCategorias.Rows[e.RowIndex].Cells[2].Value.ToString());                
            }
            catch (Exception xm)
            {
                MessageBox.Show("Favor de ingresar un valor numerico");
                gridSubCategorias.Rows[e.RowIndex].Cells[2].Value = "1";
            }
        }
    }
}