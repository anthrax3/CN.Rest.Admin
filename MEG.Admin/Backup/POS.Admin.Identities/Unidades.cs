using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    class Unidades
    {
        public Unidades()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
            _abreviatura = string.Empty;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _abreviatura;
        public string abreviatura
        {
            get { return _abreviatura; }
            set { _abreviatura = value; }
        }
    }
}
