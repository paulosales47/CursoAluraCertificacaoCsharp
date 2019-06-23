using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await FuncaoLocal();

        }

        public static async Task FuncaoLocal()
        {
            string html = await buscaHtmlGoogle("https://www.google.com/", ConsoleColor.Green, "HTML GOOGLE: ");
            Console.WriteLine(html);

            static async Task<string> buscaHtmlGoogle(string url, ConsoleColor corConsole, string preTexto)
            {
                Console.ForegroundColor = corConsole;
                string html = await new HttpClient().GetStringAsync(url);
                return $"{preTexto} {html}";
            }
        }

        public static void AlterarCorConsoleParaVerde() => Console.ForegroundColor = ConsoleColor.Green;

        public int NumeroDiaAno => DateTime.Now.DayOfYear;

        private string _nome;

        public string Nome
        {
            get => $"Nome: {_nome}";
            set => _nome = value.Trim().ToUpper();
        }

        ~Program() => Console.WriteLine("Finalizando a classe");
    }
}
