using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPagosFactory
{
    public class PayPal : IMetodoPago
    {
        public void ProcesarPago() {
            Console.WriteLine("Pagaste con tu cuenta de paypal");
        }
    }
}
