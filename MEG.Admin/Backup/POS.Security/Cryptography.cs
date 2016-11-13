using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.Configuration;
using System.IO;
//using System.Security.Cryptography;

namespace POS.Security
{
    public class Cryptography
    {
        private const string hashProvider = "SHA512Managed";
        private const string symmProvider = "RijndaelManaged";
        private static readonly string symmKeyFileName = "SymmetricKeyFile.txt";

        public static string Encrypt(string text)
        {
            if (!string.IsNullOrEmpty(text))
                //return Cryptographer.EncryptSymmetric(symmProvider, text);
                return text.Trim();
            else
                return String.Empty;
        }

        public static string Decrypt(string text)
        {
            if (!string.IsNullOrEmpty(text))
                //return Cryptographer.DecryptSymmetric(symmProvider, text);
                return text.Trim();
            else
                return String.Empty;
        }

        public static string CreateHash(string text)
        {
            if (!string.IsNullOrEmpty(text))
                return Cryptographer.CreateHash(hashProvider, text);
            else
                return String.Empty;
        }


        public static void CreateKeys()
        {
            //string installedPath = ConfigurationSettings.AppSettings.Get("InstallPath").ToString();
            //string fileName = Path.Combine(installedPath, symmKeyFileName);

            //ProtectedKey symmetricKey = KeyManager.GenerateSymmetricKey(typeof(RijndaelManaged), DataProtectionScope.LocalMachine);
            //using (FileStream keyStream = new FileStream(fileName, FileMode.Create))
            //{
            //    KeyManager.Write(keyStream, symmetricKey);
            //}
        }
    }
}
