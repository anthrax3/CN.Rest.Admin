using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Sucursales
    {
        public Sucursales()
        {
            _id = string.Empty;
            _nombre = string.Empty;
            _codigo = string.Empty;
            _razon_social = string.Empty;
            _rfc = string.Empty;
            _calle = string.Empty;
            _noExt = string.Empty;
            _noInt = string.Empty;
            _colonia = string.Empty;
            _cp = string.Empty;
            _municipioID = string.Empty;
            _estadoID = string.Empty;
            _impuestoID = string.Empty;
            _telefono = string.Empty;
            _pie = string.Empty;
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

        private string _codigo;
        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _razon_social;
        public string razon_social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }

        private string _rfc;
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        private string _calle;
        public string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        private string _noExt;
        public string noExt
        {
            get { return _noExt; }
            set { _noExt = value; }
        }

        private string _noInt;
        public string noInt
        {
            get { return _noInt; }
            set { _noInt = value; }
        }

        private string _colonia;
        public string colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        private string _cp;
        public string cp
        {
            get { return _cp; }
            set { _cp = value; }
        }

        private string _municipioID;
        public string municipioID
        {
            get { return _municipioID; }
            set { _municipioID = value; }
        }

        private string _estadoID;
        public string estadoID
        {
            get { return _estadoID; }
            set { _estadoID = value; }
        }

        private string _impuestoID;
        public string impuestoID
        {
            get { return _impuestoID; }
            set { _impuestoID = value; }
        }

        private string _telefono;
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _pie;
        public string pie
        {
            get { return _pie; }
            set { _pie = value; }
        }
    }
}
