using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aula04
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //LiteraisNumericos();
            //LiteraisNumericos2();

            //string html = await BuscarHtmlGoogle();
            //Console.WriteLine(html);

            ValoresPadrao();

            Console.ReadKey();
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

        public static async Task<string> BuscarHtmlGoogle()
        {
            return await new HttpClient().GetStringAsync("https://www.google.com/");
        }

        public static void ValoresPadrao()
        {
            //bool arg1 = default(bool); //Forma antiga
            bool arg1 = default;
            string arg2 = default;
            int arg3 = default;

            Console.WriteLine($"arg1: {arg1}, arg2: {arg2}, arg3: {arg3}");

        }
    }
}
