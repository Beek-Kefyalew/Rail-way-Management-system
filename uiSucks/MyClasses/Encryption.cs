using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace uiSucks.MyClasses.Security
{
    class Encryption
    {

        //  AES cryptography 


        private static string Key = "kiakfd123l123ufbkiakfd123l123ufb"; //32 characters = 256 bytes
        private static string IV = "a12wqjsuensloa32"; //16 characters to initialize the crypto service


        public string Encrypt(string text)
        {

            byte[] plainTextbytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            AES.BlockSize = 128;
            AES.KeySize = 256;
            AES.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            AES.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CBC;

            ICryptoTransform crypto = AES.CreateEncryptor(AES.Key, AES.IV);
            byte[] encrypted = crypto.TransformFinalBlock(plainTextbytes, 0, plainTextbytes.Length);

            
            return (Convert.ToBase64String(encrypted));
        }

        public string Decrypt(string encrypted)
        {
            byte[] encryptedbyte = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            AES.BlockSize = 128;
            AES.KeySize = 256;
            AES.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            AES.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CBC;

            ICryptoTransform crypto = AES.CreateDecryptor(AES.Key, AES.IV);
            byte[] decrypted = crypto.TransformFinalBlock(encryptedbyte, 0, encryptedbyte.Length);
            crypto.Dispose();

            
            return System.Text.ASCIIEncoding.ASCII.GetString(decrypted);
        
        }

    }

}
