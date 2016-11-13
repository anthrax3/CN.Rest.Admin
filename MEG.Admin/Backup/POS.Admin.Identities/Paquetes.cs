using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Paquetes
    {
        public Paquetes()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
            _precioVenta = string.Empty;
            _estatus = string.Empty;
            _categoria = string.Empty;
            _noArticulos = string.Empty;
            _horaInicio = string.Empty;
            _horaFin = string.Empty;
            _paqueteArticulo = new List<PaqueteArticulo>();
            _paqueteMezcladores = new List<PaqueteMezcladores>();
            _consumo = string.Empty;
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

        private string _precioVenta;
        public string precioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        private string _categoria;
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private string _noArticulos;
        public string noArticulos
        {
            get { return _noArticulos; }
            set { _noArticulos = value; }
        }

        private string _estatus;
        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private string _horaInicio;
        public string horaInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }

        private string _horaFin;
        public string horaFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }

        private string _consumo;
        public string consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }

        private List<PaqueteArticulo> _paqueteArticulo;
        public List<PaqueteArticulo> paqueteArticulo
        {
            get { return _paqueteArticulo; }
            set { _paqueteArticulo = value; }
        }

        private List<PaqueteMezcladores> _paqueteMezcladores;
        public List<PaqueteMezcladores> paqueteMezcladores
        {
            get { return _paqueteMezcladores; }
            set { _paqueteMezcladores = value; }
        }
    }

    public class PaqueteArticulo
    {
        public PaqueteArticulo()
        {
            _codigoArticulo = string.Empty;
        }

        private string _codigoArticulo;
        public string codigoArticulo
        {
            get { return _codigoArticulo; }
            set { _codigoArticulo = value; }
        }
    }

    public class PaqueteMezcladores
    {
        public PaqueteMezcladores()
        {
            _subCategoriaID = string.Empty;
            _cantidad = string.Empty;
        }

        private string _subCategoriaID;
        public string subCategoriaID
        {
            get { return _subCategoriaID; }
            set { _subCategoriaID = value; }
        }

        private string _cantidad;
        public string cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
