using System.Security.Cryptography;
using System.Text;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CRUD_Encriptacion.logica
{
    public class AESCryptography
    {
        private readonly byte[] _clave;
        private readonly byte[] _iv;

        public AESCryptography()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                _clave = sha256.ComputeHash(Encoding.UTF8.GetBytes("**PRIvada002233"));
            }

            using (MD5 md5 = MD5.Create())
            {
                _iv = md5.ComputeHash(Encoding.UTF8.GetBytes("Algosecreto123"));
            }
        }

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