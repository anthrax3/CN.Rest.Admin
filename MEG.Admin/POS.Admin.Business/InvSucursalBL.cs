using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using POS.Admin.Data;
using POS.Admin.Identities;
using System.IO;
using System.Xml.Serialization;

namespace POS.Admin.Business
{
    public class InvSucursalBL
    {
        InvSucursalDL invSucursalDL;

        public InvSucursalBL()
        {
            invSucursalDL = new InvSucursalDL();
        }

        public DataTable getInvSucursal(string sucursalID, string descripcion)
        {
            DataTable table = invSucursalDL.getInvSucursal(sucursalID, descripcion);
            return table;
        }

        public int setSolicitaCarga(string sucursalID)
        {
            return invSucursalDL.setSolicitaCarga(sucursalID);
        }

        public String genera_reporte(DataTable tbInventario, string sucursal)
        {
            string fic = "Inventario_" + sucursal + "_" + DateTime.Now.ToFileTime().ToString() + ".xls";
            if (File.Exists(fic))
                File.Delete(fic);
            StreamWriter sw = new StreamWriter(fic, false, System.Text.Encoding.Default);

            try
            {
                if (tbInventario.Rows.Count > 0)
                {
                    //CABECERA
                    sw.Write("CÓDIGO EAN" + '\t');
                    sw.Write("DESCRIPCIÓN" + '\t');
                    sw.Write("EXISTENCIA" + '\t');
                    sw.Write("FECHA EXISTENCIA" + '\n');

                    sw.Write('\n');

                    foreach (DataRow Row in tbInventario.Rows)
                    {
                        sw.Write(Row["codigo_ean"].ToString() + '\t');
                        sw.Write(Row["descripcion"].ToString() + '\t');
                        sw.Write(Row["existencia"].ToString() + '\t');
                        sw.Write(Row["ultima_modificacion"].ToString() + '\n');
                    }
                    sw.Write('\n');

                    sw.Close();

                    System.Diagnostics.Process.Start(fic);
                    return "Exportación Exitosa";
                }
                else
                    return "Es necesario cargar información";
            }
            catch (Exception xm)
            {
                return "Error al Exportar";
            }
            finally
            {

            }
        }
    }
}
