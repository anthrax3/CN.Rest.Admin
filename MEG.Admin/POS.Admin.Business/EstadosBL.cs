using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class EstadosBL
    {
        private EstadosDL estadosDL = new EstadosDL();

        public EstadosBL()
        {
            estadosDL = new EstadosDL();
        }

        public DataTable getEstados()
        {
            DataTable table = estadosDL.getEstados();
            return table;
        }

        public DataTable getMunicipios()
        {
            DataTable table = estadosDL.getMunicipios();
            return table;
        }

    }
}
