using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoApp
{
    public static class CifradorFactory
    {
        public static ICifrador Crear(string correo)
        {
            if (correo.Contains("@gmail.com"))
            {
                return new CifradorBase64();
            }
            else if (correo.Contains("@hotmail.com"))
            {
                return new CifradorAES("EstaEsMiClaveAES");
            }
            else if (correo.Contains("@itla.edu.do"))
            {
                return new CifradorDES("ClaveDES");
            }
            else
            {
                return null;
            }
        }
    }

}
