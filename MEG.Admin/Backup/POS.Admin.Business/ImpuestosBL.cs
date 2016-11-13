using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class ImpuestosBL
    {
        private ImpuestosDL impuestosDL = new ImpuestosDL();

        public ImpuestosBL()
        {
            impuestosDL = new ImpuestosDL();
        }

        public DataTable getImpuestos(string nombre)
        {
            DataTable table = impuestosDL.getImpuestos(nombre);
            return table;
        }
    }
}
