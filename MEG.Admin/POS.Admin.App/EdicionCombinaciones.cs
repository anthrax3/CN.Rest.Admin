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
    public partial class EdicionCombinaciones : Form
    {
        private PaquetesBL paquetesBL;
        private ArticulosBL articulosBL;
        private Objetos.TipoTransaccion tipoTransaccion;
        private Combinaciones combinaciones;
        private DataTable tablaProductos;
        private DataTable tablaGruposLocal;

        public EdicionCombinaciones(Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
        }

        public EdicionCombinaciones(Combinaciones _combinaciones, Objetos.TipoTransaccion _tipoTransaccion)
        {
            inicializa();
            tipoTransaccion = _tipoTransaccion;
            combinaciones = _combinaciones;
        }

        private void inicializa()
        {
            InitializeComponent();
            paquetesBL = new PaquetesBL();
            combinaciones = new Combinaciones();
            articulosBL = new ArticulosBL();
            tablaProductos = new DataTable();
            tablaGruposLocal = new DataTable();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EdicionCombinaciones_Load(object sender, EventArgs e)
        {
            cargaListas();

            if (tipoTransaccion.Equals(Objetos.TipoTransaccion.UPDATE))
            {
                txtDescripcion.Text = combinaciones.descripcion;
                txtPrecioVenta.Text = combinaciones.precioVenta;
                CBCategorias.Text = combinaciones.categoria;
                CBEstatus.Text = combinaciones.estatus;
                CBSucursal.Text = combinaciones.sucursal;
                dtInicio.Text = combinaciones.horaInicio;
                dtFin.Text = combinaciones.horaFin;
                txtConsumo.Text = combinaciones.consumo;

                GridGrupos.Rows.Clear();
                string[] obj = null;
                foreach (DataRow row in paquetesBL.getCombinacionesGrupos(combinaciones.id).Rows)
                {
                    obj = new string[4]; 
                    obj[0] = row[0].ToString();
                    obj[1] = row[1].ToString();
                    obj[2] = "";
                    obj[3] = row[2].ToString();
                    GridGrupos.Rows.Add(obj);
                }

                gridSubCategorias.Rows.Clear();
                foreach (DataRow row in paquetesBL.getCombinacionesSubCategorias(combinaciones.id).Rows)
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
            CatalogosTemp.getGrupos(foundRows[0].ItemArray[0].ToString());

            CBGrupo.Items.Clear();
            CBGrupo.Text = "";
            foreach (DataRow row in Globales.tablaGrupos.Rows)
            {
                CBGrupo.Items.Add(row["descripcion"].ToString());
            }
        }

        private void gridSubCategorias_DoubleClick(object sender, EventArgs e)
        {

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
                foundRows = Globales.tablaGrupos.Select("descripcion = '" + CBGrupo.Text.Trim() + "'");
                GridGrupos.Rows.Add(foundRows[0].ItemArray);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void btEliminaSubCat_Click(object sender, EventArgs e)
        {
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                combinaciones.descripcion = txtDescripcion.Text.Trim();
                combinaciones.precioVenta = txtPrecioVenta.Text.Trim();
                combinaciones.estatus = CBEstatus.Text.Trim();
                combinaciones.horaInicio = dtInicio.Text;
                combinaciones.horaFin = dtFin.Text;
                combinaciones.consumo = txtConsumo.Text;

                DataRow[] foundRows;
                foundRows = Globales.tablaCategorias.Select("descripcion = '" + CBCategorias.Text.Trim() + "'");
                combinaciones.categoria = foundRows[0].ItemArray[0].ToString();

                foundRows = Globales.tablaSucursales.Select("nombre = '" + CBSucursal.Text.Trim() + "'");
                combinaciones.sucursal = foundRows[0].ItemArray[0].ToString();

                combinaciones.combinacionGrupo = new List<CombinacionGrupo>();
                combinaciones.combinacionMezcladores = new List<CombinacionMezcladores>();
                CombinacionGrupo combinacionGrupo = new CombinacionGrupo();
                CombinacionMezcladores combinacionMezcladores = new CombinacionMezcladores();

                foreach (DataGridViewRow row in GridGrupos.Rows)
                {
                    combinacionGrupo = new CombinacionGrupo();
                    combinacionGrupo.grupoID = row.Cells[0].Value.ToString();
                    combinacionGrupo.cantidad = (string.IsNullOrEmpty(row.Cells[3].FormattedValue.ToString())) ? "1" : row.Cells[3].FormattedValue.ToString();
                    combinaciones.combinacionGrupo.Add(combinacionGrupo);
                }

                foreach (DataGridViewRow row in gridSubCategorias.Rows)
                {
                    combinacionMezcladores = new CombinacionMezcladores();
                    combinacionMezcladores.subCategoriaID = row.Cells[0].Value.ToString();
                    combinacionMezcladores.cantidad = (string.IsNullOrEmpty(row.Cells[2].FormattedValue.ToString())) ? "1" : row.Cells[2].FormattedValue.ToString();
                    combinaciones.combinacionMezcladores.Add(combinacionMezcladores);
                }

                MessageBox.Show(paquetesBL.setCombinaciones(combinaciones, tipoTransaccion, Globales.empresaId));
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

        private void GridGrupos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal x = Convert.ToDecimal(GridGrupos.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception xm)
            {
                MessageBox.Show("Favor de ingresar un valor numerico");
                GridGrupos.Rows[e.RowIndex].Cells[3].Value = "1";
            }
        }
    }
}