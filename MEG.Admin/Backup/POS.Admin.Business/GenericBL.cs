using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace POS.Admin.Business
{
    public class GenericBL
    {
        [DllImport("kernel32.dll")]
        static extern public int GetVersion();

        static public string mostrarVersion()
        {
            int res;
            res = GetVersion();

            int major, minor, build;

            major = LoByte(LoWord(res));
            minor = HiByte(LoWord(res));

            // A partir de NT 4 tiene el Build (no en Me/9x)
            build = HiWord(res);

            return  major + "." + minor;
        }

        static private string szTrim(string s)
        {
            // Quita los caracteres en blanco y los Chr$(0)                  (13/Dic/01)
            int i;

            // Al estilo de .NET
            i = s.IndexOf((char)0);
            if (i > -1)
            {
                s = s.Substring(0, i);
            }

            return s.Trim();
        }

        static private int LoWord(int numero)
        {
            // Devuelve el LoWord del número pasado como parámetro
            return numero & 0xFFFF;
        }

        static private int HiWord(int numero)
        {
            // Devuelve el HiWord del número pasado como parámetro
            return numero / 0x10000 & 0xFFFF;
        }

        // Para valores (0~65535)
        static private int LoByte(int numero)
        {
            return numero & 0xFF;
        }

        static private int HiByte(int numero)
        {
            return numero / 0x100 & 0xFF;
        }

    }
}
