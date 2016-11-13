using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Combinaciones
    {
        public Combinaciones()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
            _precioVenta = string.Empty;
            _estatus = string.Empty;
            _categoria = string.Empty;
            _horaInicio = string.Empty;
            _horaFin = string.Empty;
            _consumo = string.Empty;
            _combinacionGrupo = new List<CombinacionGrupo>();
            _combinacionMezcladores = new List<CombinacionMezcladores>();  
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

        private List<CombinacionGrupo> _combinacionGrupo;
        public List<CombinacionGrupo> combinacionGrupo
        {
            get { return _combinacionGrupo; }
            set { _combinacionGrupo = value; }
        }

        private List<CombinacionMezcladores> _combinacionMezcladores;
        public List<CombinacionMezcladores> combinacionMezcladores
        {
            get { return _combinacionMezcladores; }
            set { _combinacionMezcladores = value; }
        }
    }

    public class CombinacionGrupo
    {
        public CombinacionGrupo()
        {
            _grupoID = string.Empty;
        }

        private string _grupoID;
        public string grupoID
        {
            get { return _grupoID; }
            set { _grupoID = value; }
        }

        private string _cantidad;
        public string cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }

    public class CombinacionMezcladores
    {
        public CombinacionMezcladores()
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
