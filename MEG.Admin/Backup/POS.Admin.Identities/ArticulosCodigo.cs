using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class ArticulosCodigo
    {
        public ArticulosCodigo()
        {
            _ean = string.Empty;
            _descripcion = string.Empty;
        }

        private string _ean;
        public string ean
        {
            get { return _ean; }
            set { _ean = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
