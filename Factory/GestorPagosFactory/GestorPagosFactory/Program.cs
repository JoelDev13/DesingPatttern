namespace GestorPagosFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija un método de pago disponible: (No uses tilde)");
            Console.WriteLine("1. PayPal");
            Console.WriteLine("2. Tarjeta Crédito");
            Console.WriteLine("3. Transferencia Bancaria");
            Console.Write("Digite su método de pago: ");
            String Smetodo = Console.ReadLine().ToLower();

            IMetodoPago inmueble = MetodoPagoFactory.CrearMetodoDePago(Smetodo);

            inmueble.ProcesarPago();
            Console.ReadLine();
            Main(args);
        }
    }
}
