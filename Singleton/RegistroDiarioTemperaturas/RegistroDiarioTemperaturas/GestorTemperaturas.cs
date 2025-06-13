using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegistroDiarioTemperaturas
{
    internal class GestorTemperaturas
    {
        private GestorTemperaturas () { }
        private static GestorTemperaturas instance;
        private string rutaArchivo = "C:\\Users\\la\\Desktop\\Programacion\\Itla\\Programacion 2\\SINGLETON\\RegistroDiarioTemperaturas\\RegistroDiarioTemperaturas\\temperaturas.txt";
        public static GestorTemperaturas getGestorTemperatura ()
        { 
            if (instance == null)
                instance = new GestorTemperaturas ();
            return instance;
        }

        public void RegistrarTemperatura()
        {
            Console.Write("Ingrese la fecha en este formato (dd/MM/yyyy): ");
            string fechaTexto = Console.ReadLine();
            DateTime fecha = DateTime.Parse(fechaTexto);

            Console.Write("Ingrese la temperatura (°C): ");
            double temperatura = double.Parse(Console.ReadLine());

            Temperatura nuevaTemp = new Temperatura(fecha, temperatura);

            using (StreamWriter archivo = File.AppendText(rutaArchivo))
            {
                archivo.WriteLine(nuevaTemp.ToString());
            }


            Console.WriteLine("Temperatura fue correctamente ");
        }

        public void MostrarRegistros()
        {
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("No hay registros disponibles.");
                return;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            Console.WriteLine("\n=== Registros de Temperatura ===");
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }




    }
}
