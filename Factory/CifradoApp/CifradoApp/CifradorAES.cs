using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CifradoApp
{
    public class CifradorAES : ICifrador
    {
        private readonly string _clave;

        public CifradorAES(string clave) => _clave = clave;

        public string Cifrar(string texto)
        {
            using Aes aes = Aes.Create();
            using var keyDerivation = new Rfc2898DeriveBytes(_clave, new byte[] { 21, 31, 41, 51, 61, 71, 81, 91 });
            aes.Key = keyDerivation.GetBytes(32);
            aes.IV = keyDerivation.GetBytes(16);

            using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
            using var sw = new StreamWriter(cs);
            sw.Write(texto);
            sw.Close();
            return Convert.ToBase64String(ms.ToArray());
        }
    }
}
