using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestaDeSatisfaccion
{
    internal class Cliente
    {
        public String nombreCliente {  get; set; }
        public double resenia { get; set; }

        public String comentario { get; set; }

        public Cliente(String nombreCliente, double resenia, String comentario)
        {
            this.nombreCliente = nombreCliente;
            this.resenia = resenia;
            this.comentario = comentario;
        }
    }
}
