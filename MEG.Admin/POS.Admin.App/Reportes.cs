using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.Admin.Appl
{
    public partial class Reportes : Form
    {
        private string ordenID;

        public string OrdenID
        {
            get { return ordenID; }
            set { ordenID = value; }
        }

        private string almacenID;

        public string AlmacenID
        {
            get { return almacenID; }
            set { almacenID = value; }
        }

        private int tipoReporte;

        public int TipoReporte
        {
            get { return tipoReporte; }
            set { tipoReporte = value; }
        }

        public Reportes()
        {
            InitializeComponent();
            ordenID = string.Empty;
            tipoReporte = 1;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            if (tipoReporte == 1)
            {
                this.Text = "Reporte de Ordenes";
                string address = Utils.getPathReports().Trim() + "?tipo="+tipoReporte.ToString()+"&OrdenID=" + ordenID.Trim();
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 2)
            {
                this.Text = "Reporte de Comisiones";
                string address = Utils.getPathReports().Trim() + "reporteComisiones.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 3)
            {
                this.Text = "Reporte de Entradas de Mercancía";
                string address = Utils.getPathReports().Trim() + "?tipo=" + tipoReporte.ToString() + "&AlmacenID=" + almacenID.Trim();
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 4)
            {
                this.Text = "Reporte de Ventas Detalle";
                string address = Utils.getPathReports().Trim() + "reporteVentas.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 5)
            {
                this.Text = "Reporte de Códigos Generados";
                string address = Utils.getPathReports().Trim() + "?tipo=" + tipoReporte.ToString();
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 6)
            {
                this.Text = "Reporte de Propinas";
                string address = Utils.getPathReports().Trim() + "reportePropinas.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 7)
            {
                this.Text = "Reporte de Ventas Generales";
                string address = Utils.getPathReports().Trim() + "reporteVentasGeneral.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 8)
            {
                this.Text = "Reporte de Ventas por Artículo";
                string address = Utils.getPathReports().Trim() + "reporteVentasProducto.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
            else if (tipoReporte == 9)
            {
                this.Text = "Reporte de Ventas top Articulos";
                string address = Utils.getPathReports().Trim() + "reporteTopProducto.aspx";
                webBrowserReport.Navigate(new Uri(address));
            }
        }
    }
}