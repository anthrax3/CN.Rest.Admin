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
    public partial class GeneraCodigos : Form
    {
        private ArticulosBL articulosBL;

        public GeneraCodigos()
        {
            InitializeComponent();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != string.Empty)
                {
                    articulosBL = new ArticulosBL();

                    int tipo = 0;
                    if (radioDescripcion.Checked) tipo = 1;
                    if (radioEan.Checked) tipo = 2;

                    if (tipo > 0)
                    {
                        gridBusqueda.DataSource = articulosBL.getArticulos(txtBuscar.Text, tipo, Globales.empresaId);
                        txtBuscar.Text = "";
                    }
                }
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
                ArticulosCodigo articulosCodigo;
                List<ArticulosCodigo> listaArticulosCodigo = new List<ArticulosCodigo>();
                for (int x = 0; x < gridBusqueda.SelectedRows.Count; x++)
                {
                    articulosCodigo = new ArticulosCodigo();
                    articulosCodigo.ean = gridBusqueda.SelectedRows[x].Cells[0].Value.ToString();
                    articulosCodigo.descripcion = gridBusqueda.SelectedRows[x].Cells[1].Value.ToString();
                    listaArticulosCodigo.Add(articulosCodigo);
                }

                gridListado.DataSource = listaArticulosCodigo;
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void gridListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            barcodeNETWindows1.BarcodeText = gridListado.SelectedCells[0].Value.ToString();
        }

        private void BTGenera_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists("imagenes"))
                    Directory.CreateDirectory("imagenes");

                articulosBL = new ArticulosBL();
                FileStream fs;
                BinaryReader r;
                string strImagen = string.Empty;

                ArticulosImagen artCodigo = new ArticulosImagen();
                List<ArticulosImagen> listaArtCodigo = new List<ArticulosImagen>();

                foreach (DataGridViewRow row in gridListado.Rows)
                {
                    barcodeNETWindows1.BarcodeText = row.Cells[0].Value.ToString();

                    if (File.Exists("imagenes\\" + row.Cells[0].Value.ToString() + ".jpg"))
                        File.Delete("imagenes\\" + row.Cells[0].Value.ToString() + ".jpg");

                    barcodeNETWindows1.SaveToFile("imagenes\\" + row.Cells[0].Value.ToString() + ".jpg", BarcodeNETWorkShop.Core.FILE_FORMAT.JPG);

                    fs = new FileStream("imagenes\\" + row.Cells[0].Value.ToString() + ".jpg", FileMode.Open, FileAccess.Read);
                    r = new BinaryReader(fs);
                    Byte[] imagen = r.ReadBytes(Convert.ToInt32(fs.Length));
                    r.Close();

                    artCodigo = new ArticulosImagen();
                    artCodigo.imagen = imagen;
                    artCodigo.ean = row.Cells[0].Value.ToString();
                    listaArtCodigo.Add(artCodigo);

                    strImagen = string.Empty;
                }

                if (articulosBL.setImagenCodigo(listaArtCodigo, Globales.empresaId) > 0)
                    MessageBox.Show("Códigos generados exitosamente");
                else
                    MessageBox.Show("No se pudieron agregar las imagenes al catálogo", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message);
            }
        }

        private void BTImprime_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.TipoReporte = 5;
            reportes.ShowDialog();
        }
    }
}