using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CifradoApp
{
    public class CifradorDES : ICifrador
    {
        private readonly string _clave;

        public CifradorDES(string clave) => _clave = clave;

        public string Cifrar(string texto)
        {
            using var des = DES.Create();
            des.Key = Encoding.UTF8.GetBytes(_clave.PadRight(8).Substring(0, 8));
            des.IV = des.Key;

            using var encryptor = des.CreateEncryptor(des.Key, des.IV);
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
            using var sw = new StreamWriter(cs);
            sw.Write(texto);
            sw.Close();
            return Convert.ToBase64String(ms.ToArray());
        }
    }
}
