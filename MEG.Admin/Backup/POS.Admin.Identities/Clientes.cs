using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Clientes
    {
        public Clientes()
        {
            _id = string.Empty;
            _rfc = string.Empty;
            _nombreComercial = string.Empty;
            _razonSocial = string.Empty;
            _calle = string.Empty;
            _noExt = string.Empty;
            _noInt = string.Empty;
            _colonia = string.Empty;
            _cp = string.Empty;
            _municipioID = string.Empty;
            _estadoID = string.Empty;
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

        private string _nombreComercial;
        public string nombreComercial
        {
            get { return _nombreComercial; }
            set { _nombreComercial = value; }
        }

        private string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
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
    }
}
