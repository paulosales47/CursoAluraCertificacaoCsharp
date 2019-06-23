using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            LiteraisNumericos();
            LiteraisNumericos2();

        }

        public static void LiteraisNumericos()
        {
            var numero1 = 0b0001;
            var numero2 = 0b0010;
            var numero4 = 0b0100;
            var numero8 = 0b1000;

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero4);
            Console.WriteLine(numero8);
        }

        public static void LiteraisNumericos2()
        {
            const double AVOGRADO = 6.022140857747474E23;
            const double AVOGRADO_NEW = 6.022_140_857_747_474E23;

            Console.WriteLine(AVOGRADO);
            Console.WriteLine(AVOGRADO_NEW);
        }
    }
}
