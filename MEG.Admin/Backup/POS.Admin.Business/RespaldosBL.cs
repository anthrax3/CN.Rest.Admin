using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;

namespace POS.Admin.Business
{
    public class RespaldosBL
    {
        private RespaldosDL respaldosDL = new RespaldosDL();

        public RespaldosBL()
        {
            respaldosDL = new RespaldosDL();
        }

        public DataTable getRespaldos(string sucursalID)
        {
            DataTable table = respaldosDL.getRespaldos(sucursalID);
            return table;
        }
    }
}
