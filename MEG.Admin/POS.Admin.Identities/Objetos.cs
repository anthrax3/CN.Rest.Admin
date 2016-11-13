using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Admin.Identities
{
    public class Objetos
    {
        public Objetos()
        {

        }

        public enum TipoTransaccion
        {
            UPDATE,
            INSERT,
            DELETE
        }

        public enum EstatusOrden
        {
            PENDIENTE,
            RECIBIDA,
            PROCESADA
        }

        public enum EstatusEntrada
        {
            PENDIENTE,
            INGRESADA,
            CANCELADA
        }
    }
}
