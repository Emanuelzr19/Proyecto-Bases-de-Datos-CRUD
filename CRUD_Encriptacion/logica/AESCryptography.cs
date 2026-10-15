using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CRUD_Encriptacion.logica
{
    public class AESCryptography
    {
        private readonly byte[] _clave = Encoding.UTF8.GetBytes("**PRIvada002233");
        private readonly byte[] _iv = Encoding.UTF8.GetBytes("VectorInicio1234");

        public byte[] Encriptar(string textoPlano)
        {
            if (string.IsNullOrEmpty(textoPlano)) return null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = _clave;
                aesAlg.IV = _iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(textoPlano);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        public string Desencriptar(byte[] textoCifrado)
        {
            if (textoCifrado == null || textoCifrado.Length == 0) return "";

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = _clave;
                aesAlg.IV = _iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(textoCifrado))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}