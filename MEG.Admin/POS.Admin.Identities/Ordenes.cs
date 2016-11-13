using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Ordenes
    {
        public Ordenes()
        {
            _id = string.Empty;
            _noOrden = string.Empty;
            _factura = string.Empty;
            _sucursalID = string.Empty;
            _proveedorID = string.Empty;
            _subtotal = string.Empty;
            _total_iva = string.Empty;
            _grantotal = string.Empty;
            _estatus = string.Empty;
            OrdenDetalle = new List<ordenDetalle>();
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _noOrden;
        public string noOrden
        {
            get { return _noOrden; }
            set { _noOrden = value; }
        }

        private string _factura;
        public string factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        private string _sucursalID;
        public string sucursalID
        {
            get { return _sucursalID; }
            set { _sucursalID = value; }
        }

        private string _proveedorID;
        public string proveedorID
        {
            get { return _proveedorID; }
            set { _proveedorID = value; }
        }

        private string _subtotal;
        public string subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        private string _total_iva;
        public string total_iva
        {
            get { return _total_iva; }
            set { _total_iva = value; }
        }

        private string _grantotal;
        public string grantotal
        {
            get { return _grantotal; }
            set { _grantotal = value; }
        }

        private string _estatus;
        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public List<ordenDetalle> OrdenDetalle = new List<ordenDetalle>();
    }

    public class ordenDetalle
    {
        public ordenDetalle()
        {
            _id = string.Empty;
            _ordenID = string.Empty;
            _ean = string.Empty;
            _descripcion = string.Empty;
            _cantidad = string.Empty;
            _venta = string.Empty;
            _costo = string.Empty;
            _subtotal = string.Empty;
            _iva = string.Empty;
            _total = string.Empty;
            _porcentaje_iva = string.Empty;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _ordenID;
        public string ordenID
        {
            get { return _ordenID; }
            set { _ordenID = value; }
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

        private string _cantidad;
        public string cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string _venta;
        public string venta
        {
            get { return _venta; }
            set { _venta = value; }
        }

        private string _costo;
        public string costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private string _subtotal;
        public string subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        private string _iva;
        public string iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        private string _total;
        public string total
        {
            get { return _total; }
            set { _total = value; }
        }

        private string _porcentaje_iva;
        public string porcentaje_iva
        {
            get { return _porcentaje_iva; }
            set { _porcentaje_iva = value; }
        }
    }
}
