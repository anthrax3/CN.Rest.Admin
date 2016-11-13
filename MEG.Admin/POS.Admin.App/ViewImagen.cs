using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Admin.Appl
{
    public partial class ViewImagen : Form
    {
        private string _imagen = string.Empty;

        public ViewImagen(string imagen)
        {
            InitializeComponent();
            _imagen = imagen;
        }

        private void ViewImagen_Load(object sender, EventArgs e)
        {
            System.Uri url = new Uri("http://50.57.224.133/img/4/" + _imagen);
            wbImg.Url = url;
        }
    }
}
