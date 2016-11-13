using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class ArticulosImagen
    {
        public ArticulosImagen()
        {
            _ean = string.Empty;
            _imagen = new byte[1];
        }

        private string _ean;
        public string ean
        {
            get { return _ean; }
            set { _ean = value; }
        }

        private byte[] _imagen;
        public byte[] imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
    }
}