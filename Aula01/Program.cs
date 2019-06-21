using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Ref();

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

        public static void Ref()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ref int numero = ref RetornarReferenciaIndice(6, numeros);
            numero = -6;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        public static ref int RetornarReferenciaIndice(int valorProcurado, int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == valorProcurado)
                    return ref numeros[i];
            }

            throw new IndexOutOfRangeException("Valor não encontrado no array");
        }



        public static void Barra()
        {
            Console.WriteLine("============================================================================");
        }
    }
}
