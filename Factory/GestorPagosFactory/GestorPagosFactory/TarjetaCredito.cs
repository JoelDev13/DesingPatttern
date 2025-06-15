using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPagosFactory
{
    public class TarjetaCredito :IMetodoPago
    {
        public void ProcesarPago()
        {
            Console.WriteLine("Pagaste con targeta de credito");
        }
    }
}
