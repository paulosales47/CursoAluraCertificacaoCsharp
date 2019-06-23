using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //PatternMatching();

            PatternMatching2();

            Console.ReadKey();
        }

        public static void PatternMatching()
        {
            var itens = new object[] { "1", "2", 3, 4, "5" };
            
            if(itens is IEnumerable<object> colecao)
            {
                foreach (var item in colecao)
                {
                    Console.WriteLine($"{item} - {item.GetType()}");
                }
            }
        }

        public static void PatternMatching2()
        {
            object parametro = "   ";


            switch (parametro)
            {
                case double parametroDouble:
                    Console.WriteLine("Double");
                break;

                case float parametroFloat:
                    Console.WriteLine("Float");
                    break;

                case int parametroInt:
                    Console.WriteLine("Int");
                    break;

                case string parametroString when (parametroString.Trim().Length == 0):
                    Console.WriteLine("String vazia");
                    break;

                case string parametroString when (parametroString.Trim().Length > 0):
                    Console.WriteLine("String");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }

        }

        public static void Barra()
        {
            Console.WriteLine("============================================================================");
        }


    }


}
