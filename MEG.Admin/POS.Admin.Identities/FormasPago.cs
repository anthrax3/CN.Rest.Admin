using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class FormasPago
    {
        public FormasPago()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
            _estatus = string.Empty;
            _credito = false;
            _principal = 0;
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

        private string _estatus;
        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private bool _credito;
        public bool credito
        {
            get { return _credito; }
            set { _credito = value; }
        }

        private int _principal;
        public int principal
        {
            get { return _principal; }
            set { _principal = value; }
        }
    }
}
