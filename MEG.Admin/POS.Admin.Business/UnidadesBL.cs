using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class UnidadesBL
    {
        private UnidadesDL unidadesDL = new UnidadesDL();

        public UnidadesBL()
        {
            unidadesDL = new UnidadesDL();
        }

        public DataTable getUnidades(string nombre)
        {
            DataTable table = unidadesDL.getUnidades(nombre);
            return table;
        }
    }
}
