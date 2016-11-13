using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.Admin.Business;
using POS.Admin.Identities;
using System.IO;

namespace POS.Admin.Appl
{
    public partial class EdicionArticulosProveedor : Form
    {
        private DataTable tablaProveedores;
        private ArticulosBL articulosBL;

        public EdicionArticulosProveedor(DataTable _tablaProveedores)
        {
            inicializa();
            tablaProveedores = _tablaProveedores;
        }

        private void inicializa()
        {
            InitializeComponent();
            tablaProveedores = new DataTable();
        }

        private void EdicionArticulosProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                articulosBL = new ArticulosBL();

                CBProveedor.Items.Clear();
                foreach (DataRow row in tablaProveedores.Rows)
                    CBProveedor.Items.Add(row["descripcion"]);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            try
            {
                int proveedorID = getProveedorID();
                if ((txtBuscar.Text != string.Empty) && (proveedorID > 0))
                {
                    int tipo = 0;
                    if (radioDescripcion.Checked) tipo = 1;
                    if (radioEan.Checked) tipo = 2;

                    if (tipo > 0)
                    {
                        gridBusqueda.DataSource = articulosBL.getArticulosSinProveedor(txtBuscar.Text, tipo, proveedorID, Globales.empresaId);
                        txtBuscar.Text = "";
                    }
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gridArticulosProv.DataSource = articulosBL.getArticulosProveedor(getProveedorID(), Globales.empresaId);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void BTMover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea Agregar los artículos seleccionados?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int proveedorID = getProveedorID();
                    if (getProveedorID() > 0)
                    {
                        ArticulosCodigo articulosCodigo;
                        List<ArticulosCodigo> listaArticulosCodigo = new List<ArticulosCodigo>();
                        ArticulosProveedor articulosProveedor;
                        List<ArticulosProveedor> listaArtProveedor = new List<ArticulosProveedor>();

                        for (int x = 0; x < gridBusqueda.SelectedRows.Count; x++)
                        {
                            articulosCodigo = new ArticulosCodigo();
                            articulosCodigo.ean = gridBusqueda.SelectedRows[x].Cells[0].Value.ToString();
                            articulosCodigo.descripcion = gridBusqueda.SelectedRows[x].Cells[1].Value.ToString();
                            listaArticulosCodigo.Add(articulosCodigo);

                            articulosProveedor = new ArticulosProveedor();
                            articulosProveedor.ean = articulosCodigo.ean;
                            articulosProveedor.proveedorID = proveedorID;
                            listaArtProveedor.Add(articulosProveedor);
                        }

                        if (articulosBL.ins_articulo_proveedor(listaArtProveedor, Globales.empresaId) > 0)
                            gridArticulosProv.DataSource = listaArticulosCodigo;
                        else
                            MessageBox.Show("No se pudieron agregar los artículos al catálogo","Error Inesperado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Debe seleccionar primero un proveedor","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void BTBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = gridArticulosProv.SelectedCells[0].Value.ToString();

                if (MessageBox.Show("Desea Eliminar el Artículo: " + codigo + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int res = articulosBL.delArticuloProv(codigo, getProveedorID(), Globales.empresaId);

                    if (res > 0)
                    {
                        MessageBox.Show("Se borró el artículo");
                        gridArticulosProv.Rows.RemoveAt(gridArticulosProv.SelectedCells[0].ColumnIndex);
                    }
                    else
                        MessageBox.Show("No se pudo borrar el artículo");
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
            
        }

        private int getProveedorID()
        {
            int proveedorID = 0;

            foreach (DataRow row in tablaProveedores.Rows)
            {
                if (row["descripcion"].Equals(CBProveedor.Text.Trim()))
                {
                    proveedorID = int.Parse(row["proveedorID"].ToString());
                    break;
                }
            }

            return proveedorID;
        }

        private void CBProveedor_TextChanged(object sender, EventArgs e)
        {
            gridBusqueda.DataSource = null; ;
        }

    }
}