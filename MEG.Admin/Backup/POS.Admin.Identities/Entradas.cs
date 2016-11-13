using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Entradas
    {
        public Entradas()
        {
            _entradaID = string.Empty;
            _proveedorID = string.Empty;
            _proveedor_compraID = string.Empty;
            _fecha_entrada = string.Empty;
            _fecha_generacion = string.Empty;
            _estatus = string.Empty;
            _factura = string.Empty;
            _folio = string.Empty;
            _importeCero = string.Empty;
            _importeQuince = string.Empty;
            entradaDetalle = new List<EntradaDetalle>();
        }

        private string _entradaID;
        public string entradaID
        {
            get { return _entradaID; }
            set { _entradaID = value; }
        }

        private string _proveedorID;
        public string proveedorID
        {
            get { return _proveedorID; }
            set { _proveedorID = value; }
        }

        private string _proveedor_compraID;
        public string proveedor_compraID
        {
            get { return _proveedor_compraID; }
            set { _proveedor_compraID = value; }
        }

        private string _fecha_entrada;
        public string fecha_entrada
        {
            get { return _fecha_entrada; }
            set { _fecha_entrada = value; }
        }

        private string _fecha_generacion;
        public string fecha_generacion
        {
            get { return _fecha_generacion; }
            set { _fecha_generacion = value; }
        }

        private string _estatus;
        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private string _factura;
        public string factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        private string _folio;
        public string folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        private string _importeCero;
        public string importeCero
        {
            get { return _importeCero; }
            set { _importeCero = value; }
        }

        private string _importeQuince;
        public string importeQuince
        {
            get { return _importeQuince; }
            set { _importeQuince = value; }
        }

        public List<EntradaDetalle> entradaDetalle = new List<EntradaDetalle>();
    }

    public class EntradaDetalle
    {
        public EntradaDetalle()
        {
            _id = string.Empty;
            _entradaID = string.Empty;
            _ean = string.Empty;
            _descripcion = string.Empty;
            _cantidad = string.Empty;
            _costo = string.Empty;
            _venta = string.Empty;
            _porcentaje_iva = string.Empty;
            _subtotalCero = string.Empty;
            _subtotalQuince = string.Empty;
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _entradaID;
        public string entradaID
        {
            get { return _entradaID; }
            set { _entradaID = value; }
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

        private string _porcentaje_iva;
        public string porcentaje_iva
        {
            get { return _porcentaje_iva; }
            set { _porcentaje_iva = value; }
        }

        private string _subtotalCero;
        public string subtotalCero
        {
            get { return _subtotalCero; }
            set { _subtotalCero = value; }
        }
        private string _subtotalQuince;
        public string subtotalQuince
        {
            get { return _subtotalQuince; }
            set { _subtotalQuince = value; }
        }
    }
}
