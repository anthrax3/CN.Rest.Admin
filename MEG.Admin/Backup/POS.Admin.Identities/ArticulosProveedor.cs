using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class ArticulosProveedor
    {
        public ArticulosProveedor()
        {
            _ean = string.Empty;
            _proveedorID = 0;
        }

        private string _ean;
        public string ean
        {
            get { return _ean; }
            set { _ean = value; }
        }

        private int _proveedorID;
        public int proveedorID
        {
            get { return _proveedorID; }
            set { _proveedorID = value; }
        }
    }
}
