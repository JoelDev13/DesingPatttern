using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CifradoApp;

public class CifradorBase64 : ICifrador
{
    public string Cifrar(string texto) =>
        Convert.ToBase64String(Encoding.UTF8.GetBytes(texto));
}

