using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class SubCategorias
    {
        public SubCategorias()
        {
            _categoriaID = string.Empty;
            _id = string.Empty;
            _descripcion = string.Empty;
            _empresaID = string.Empty;
        }

        private string _categoriaID;
        public string categoriaID
        {
            get { return _categoriaID; }
            set { _categoriaID = value; }
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

        private string _empresaID;
        public string empresaID
        {
            get { return _empresaID; }
            set { _empresaID = value; }
        }
    }
}
