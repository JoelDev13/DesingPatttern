using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPagosFactory
{
    public class MetodoPagoFactory
    {
        public static IMetodoPago CrearMetodoDePago(string Smetodo) { 
            if (Smetodo == "paypal")
                return new PayPal();
            if (Smetodo == "tarjeta credito")
                return new TarjetaCredito();
            if (Smetodo == "transferencia bancaria")
                return new TransferenciaBancaria();
            else
                return null;

        }   
    }
}

