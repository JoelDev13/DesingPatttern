using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPagosFactory
{
    public class TransferenciaBancaria : IMetodoPago
    {
        public void ProcesarPago()
        {
            Console.WriteLine("Pagaste mediante una transferencia bancaria");
        }
    }
}
