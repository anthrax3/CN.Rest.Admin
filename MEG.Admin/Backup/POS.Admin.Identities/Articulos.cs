using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Articulos
    {
        public Articulos()
        {
            _id = string.Empty;
            _ean = string.Empty;
            _descripcion = string.Empty;
            _medida = string.Empty;
            _costo = string.Empty;
            _venta = string.Empty;
            _iva = string.Empty;
            _estatus = string.Empty;
            _unidad = string.Empty;
            _grupo = string.Empty;
            _subcategoria = string.Empty;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
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

        private string _medida;
        public string medida
        {
            get { return _medida; }
            set { _medida = value; }
        }

        private string _costo;
        public string costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private string _venta;
        public string venta
        {
            get { return _venta; }
            set { _venta = value; }
        }

        private string _iva;
        public string iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        private string _estatus;
        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private string _unidad;
        public string unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        private string _grupo;
        public string grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        private string _subcategoria;
        public string subcategoria
        {
            get { return _subcategoria; }
            set { _subcategoria = value; }
        }
    }
}
