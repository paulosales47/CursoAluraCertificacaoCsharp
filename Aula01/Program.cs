using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Out();


            Console.ReadKey();
        }

        public static void Out()
        {
            Barra();
            string numero = "512";
            int numeroConvertido = int.TryParse(numero, out int numeroOut) ? numeroOut : 0;
            Console.WriteLine(numeroConvertido);
            Barra();
        }

        public static void Barra()
        {
            Console.WriteLine("============================================================================");
        }
    }
}
