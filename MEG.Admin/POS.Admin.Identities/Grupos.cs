using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Grupos
    {
        public Grupos()
        {
            _grupoID = string.Empty;
            _subcategoriaId = string.Empty;
            _descripcion = string.Empty;
        }

        private string _grupoID;
        public string grupoID
        {
            get { return _grupoID; }
            set { _grupoID = value; }
        }

        private string _subcategoriaId;
        public string subcategoriaId
        {
            get { return _subcategoriaId; }
            set { _subcategoriaId = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
