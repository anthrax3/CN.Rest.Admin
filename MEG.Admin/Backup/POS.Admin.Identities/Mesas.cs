using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Mesas
    {
        public Mesas()
        {
            _id = string.Empty;
            _nombre = string.Empty;
            _numero = string.Empty;
            _sucursalID = string.Empty;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _numero;
        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _sucursalID;
        public string sucursalID
        {
            get { return _sucursalID; }
            set { _sucursalID = value; }
        }
    }
}
