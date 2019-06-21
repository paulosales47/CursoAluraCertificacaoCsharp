using System;

namespace TestesCsharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Array();

            TesteIndex();

            Console.ReadKey();
        }

        public static void Array()
        {
            Barra();
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numeros2 = numeros[1..5];
            int ultimoItem = numeros[^1];

            foreach (var numero in numeros2) //1,2,3,4
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine(ultimoItem); //10

            Barra();
        }

        public static void TesteIndex()
        {
            Barra();
            Index i1 = 3;
            Index i2 = ^4; //Quarto numero começando pelo final

            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"{numeros[i1]}, {numeros[i2]}"); //3,7
            Barra();
        }

        public static void Barra()
        {
            Console.WriteLine("============================================================================");
        }
    }
}
