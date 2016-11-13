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

using System.Diagnostics;
using Telerik.WinControls;
namespace POS.Admin.Appl
{
    public partial class MainForm : Form
    {
        #region Variables

        private SeguridadBL seguridadBL;

        #endregion Variables

        #region Principal

        public MainForm()
        {

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucCatalogos1.Enabled = false;
            ucSeguridad1.Enabled = false;
            ucMovimientos1.Enabled = false;
            ucCatalogos1.Visible = false;
            ucSeguridad1.Visible = false;
            ucMovimientos1.Visible = false;

            //Modificar grids
            Globales.modificaOrden = false;
            Globales.modificaEntrada = false;
            Globales.modificaSucursal = false;
            Globales.modificaProveedor = false;
            Globales.modificaDevolucion = false;
            Globales.modificaArticulos = false;
            Globales.modificaCategorias = false;
            Globales.modificaPaquetes = false;
            Globales.modificaMesa = false;
            Globales.empresaId = "0";

            deshabilitaPestanas();
            deshabilitaBotones();
        }

        private void tbConnect_Click(object sender, EventArgs e)
        {
            try
            {
                seguridadBL = new SeguridadBL();

                Acceso acceso = new Acceso(seguridadBL);
                acceso.ShowDialog();

                if (acceso.status)
                {
                    seguridadBL = new SeguridadBL();

                    Globales.empresaId = Globales.tablaAccesos.Rows[0].ItemArray[5].ToString();
                    Globales.pathImg = Globales.tablaAccesos.Rows[0].ItemArray[6].ToString();

                    //MessageBox.Show("El sistema esta conectado al Servidor Remoto", "Conexión Satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CatalogosTemp.actualizaCatalogos();

                    acceso.Dispose();

                    habilitaBotones();
                }
                else
                {
                    seguridadBL = null;
                }
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error al Conectar con Servidor Remoto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaBotones()
        {
            tbDisconnect.Enabled = true;
            tbActiveSync.Enabled = false;
            tbActiveSync.Visible = false;
            tbCatalogos.Enabled = true;
            tbOperaciones.Enabled = true;
            tbSeguridad.Enabled = true;
        }

        private void deshabilitaBotones()
        {
            tbDisconnect.Enabled = false;
            tbActiveSync.Enabled = false;
            tbActiveSync.Visible = false;
            tbCatalogos.Enabled = false;
            tbOperaciones.Enabled = false;
            tbSeguridad.Enabled = false;
        }

        private void tbDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                tbDisconnect.Enabled = false;
                tbActiveSync.Enabled = false;
                Globales.empresaId = "0";
                deshabilitaBotones();
                deshabilitaPestanas();
            }
            catch (Exception xm)
            {
                MessageBox.Show(xm.Message, "Error al Desconectar con Servidor Remoto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbActiveSync_Click(object sender, EventArgs e)
        {
            string version = GenericBL.mostrarVersion();
            string[] control = version.Split('.');

            if (control[0].Equals("5") && control[1].Equals("1"))
                Process.Start(@"C:\Archivos de programa\Microsoft ActiveSync\WCESMgr.exe");
            else if (control[0].Equals("6"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = true;
                startInfo.FileName = @"C:\Windows\WindowsMobile\wmdc.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = "/show";
                Process hbProc = new Process();
                hbProc = Process.Start(startInfo);
                hbProc.WaitForExit();
            }
        }

        private void tbCatalogos_Click(object sender, EventArgs e)
        {
            ucCatalogos1.aplicaPoliticas();
            ucCatalogos1.Enabled = true;
            ucCatalogos1.Visible = true;
            ucSeguridad1.Enabled = false;
            ucSeguridad1.Visible = false;
            ucMovimientos1.Visible = false;
            ucMovimientos1.Enabled = false;
        }

        private void tbOperaciones_Click(object sender, EventArgs e)
        {
            ucMovimientos1.aplicaPoliticas();
            ucMovimientos1.Enabled = true;
            ucMovimientos1.Visible = true;
            ucCatalogos1.Visible = false;
            ucCatalogos1.Enabled = false;
            ucSeguridad1.Enabled = false;
            ucSeguridad1.Visible = false;
        }

        private void tbSeguridad_Click(object sender, EventArgs e)
        {
            ucSeguridad1.aplicaPoliticas();
            ucSeguridad1.Enabled = true;
            ucSeguridad1.Visible = true;
            ucMovimientos1.Enabled = false;
            ucMovimientos1.Visible = false;
            ucCatalogos1.Enabled = false;
            ucCatalogos1.Visible = false;
        }

        private void deshabilitaPestanas()
        {
            ucCatalogos1.Enabled = false;
            ucSeguridad1.Enabled = false;
            ucMovimientos1.Enabled = false;
            ucCatalogos1.Visible = false;
            ucSeguridad1.Visible = false;
            ucMovimientos1.Visible = false;
        }

        #endregion Principal

    }
}