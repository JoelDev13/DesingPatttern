using System;

namespace ActivityLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== ActivityLoggerApp ===");

            ActivityLogger.Instance.Log();
            ActivityLogger.Instance.ShowLog();
            Console.ReadLine(); 
        }
    }
}
