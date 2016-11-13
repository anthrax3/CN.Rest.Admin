using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class CategoriasBL
    {
        private CategoriasDL categoriasDL = new CategoriasDL();

        public CategoriasBL()
        {
            categoriasDL = new CategoriasDL();
        }

        #region Categorias

        public DataTable getCategorias(string nombre, string empresaID)
        {
            DataTable table = categoriasDL.getCategorias(nombre, empresaID);
            return table;
        }

        public string setCategorias(Categorias categorias, Objetos.TipoTransaccion tipoTransaccion, string empresaID)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = categoriasDL.existe_categorias(categorias.descripcion, empresaID);
                    if (value > 0)
                        response = "Ya existe la Categoria con ID: " + value.ToString();
                    else
                    {
                        if (categoriasDL.genera_categoria(categorias, "ins_categoria", empresaID) > 0)
                            response = "Nueva Categoria agregada";
                        else
                            response = "Error, no se pudo insertar la Categoria";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (categoriasDL.genera_categoria(categorias, "upd_categoria", empresaID) > 0)
                        response = "Categoria modificada";
                    else
                        response = "Error, no se pudo modificar la Categoria";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaCategoria(Categorias categorias)
        {
            if (categoriasDL.eliminaCategoria(categorias) > 0)
                return "Categoria con ID: " + categorias.id + " borrada";
            else
                return "Categoria con ID: " + categorias.id + " no pudo ser borrada";
        }

        #endregion Categorias

        #region SubCategorias

        public DataTable getSubCategorias(string categoriaID)
        {
            DataTable table = categoriasDL.getSubCategorias(categoriaID);
            return table;
        }

        public DataTable getSubCategoriasAll(string empresaID)
        {
            DataTable table = categoriasDL.getSubCategoriasAll(empresaID);
            return table;
        }

        public string setSubCategorias(SubCategorias subCategorias, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = categoriasDL.existe_subCategoria(subCategorias);
                    if (value > 0)
                        response = "Ya existe la SubCategoria con ID: " + value.ToString();
                    else
                    {
                        if (categoriasDL.genera_subCategoria(subCategorias, "ins_subcategoria") > 0)
                            response = "Nueva SubCategoria agregada";
                        else
                            response = "Error, no se pudo insertar la SubCategoria";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (categoriasDL.genera_subCategoria(subCategorias, "upd_subcategoria") > 0)
                        response = "SubCategoria modificada";
                    else
                        response = "Error, no se pudo modificar la SubCategoria";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaSubCategoria(SubCategorias subCategorias)
        {
            if (categoriasDL.eliminaSubCategoria(subCategorias) > 0)
                return "SubCategoria con ID: " + subCategorias.id + " borrada";
            else
                return "SubCategoria con ID: " + subCategorias.id + " no pudo ser borrada";
        }

        #endregion SubCategorias

        #region Grupos

        public DataTable getGrupos(string subCategoriaID)
        {
            DataTable table = categoriasDL.getGrupos(subCategoriaID);
            return table;
        }

        public DataTable getGruposAll()
        {
            DataTable table = categoriasDL.getGruposAll();
            return table;
        }

        public string setGrupos(Grupos grupos, Objetos.TipoTransaccion tipoTransaccion)
        {
            string response = string.Empty;
            switch (tipoTransaccion)
            {
                case Objetos.TipoTransaccion.INSERT:
                    int value = categoriasDL.existe_grupo(grupos);
                    if (value > 0)
                        response = "Ya existe el Grupo con ID: " + value.ToString();
                    else
                    {
                        if (categoriasDL.genera_Grupo(grupos, "ins_grupo") > 0)
                            response = "Nuevo Grupo agregado";
                        else
                            response = "Error, no se pudo insertar el Grupo";
                    }
                    break;
                case Objetos.TipoTransaccion.UPDATE:
                    if (categoriasDL.genera_Grupo(grupos, "upd_grupo") > 0)
                        response = "Grupo modificado";
                    else
                        response = "Error, no se pudo modificar el Grupo";
                    break;
                default:
                    break;
            }
            return response;
        }

        public string eliminaGrupo(Grupos grupos)
        {
            if (categoriasDL.eliminaGrupo(grupos) > 0)
                return "Grupo con ID: " + grupos.grupoID + " borrado";
            else
                return "Grupo con ID: " + grupos.grupoID + " no pudo ser borrado";
        }

        #endregion Grupos

        

     
    }
}
