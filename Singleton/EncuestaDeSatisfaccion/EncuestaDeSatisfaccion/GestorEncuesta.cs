using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncuestaDeSatisfaccion
{
    internal class GestorEncuesta
    {
        private GestorEncuesta() { }
        private static GestorEncuesta instance;
        private string rutaArchivo = "C:\\Users\\la\\Desktop\\Programacion\\Itla\\Programacion 2\\SINGLETON\\EncuestaDeSatisfaccion\\EncuestaDeSatisfaccion\\encuesta.txt";
        public static GestorEncuesta GetInstance()
        {
            if (instance == null)
                instance = new GestorEncuesta();
            return instance;
        }

        public void RegistrarEncuestaa()
        {
            Console.Write("ingrese su nombre");
            string nombreCliente = Console.ReadLine();

            Console.Write("ingrese su calificacion (1 al 5)");
            double resenia = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese su comentario");
            String  comentario = Console.ReadLine();

            Cliente nuevaEnc = new Cliente(nombreCliente, resenia, comentario);

            using (StreamWriter archivo = File.AppendText(rutaArchivo))
            {
                archivo.WriteLine($"Cliente: {nuevaEnc.nombreCliente}");
                archivo.WriteLine($"Calificación: {nuevaEnc.resenia}");
                archivo.WriteLine($"Comentario: {nuevaEnc.comentario}");
                archivo.WriteLine("---");
            }



            Console.WriteLine("datos correctamente ");
        }

        public void MostrarEncuesta()
        {
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("No hay encuesta disponibles");
                return;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            Console.WriteLine("\n=== Registros de encuesta ===");
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }
    }
}
