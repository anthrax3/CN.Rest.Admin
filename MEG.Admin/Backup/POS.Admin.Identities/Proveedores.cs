using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Proveedores
    {
        public Proveedores()
        {
            _id = string.Empty;
            _rfc = string.Empty;
            _razon = string.Empty;
            _alias = string.Empty;
            _direccion = string.Empty;
            _almacen = false;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _rfc;
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        private string _razon;
        public string razon
        {
            get { return _razon; }
            set { _razon = value; }
        }

        private string _alias;
        public string alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private bool _almacen;
        public bool almacen
        {
            get { return _almacen; }
            set { _almacen = value; }
        }

    }
}
