using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //Tupla();

            Descartes();

            Console.ReadKey();
        }

        public static void Tupla()
        {
            Barra();
            Tuple<int, string, double> tupleAntigo = RetornarPedidosAntigo();
            Console.WriteLine($"{tupleAntigo.Item1} - {tupleAntigo.Item2} - {tupleAntigo.Item3}");

            var (numeroPedido, nomeCliente, valorPedido) = RetornarPedidosNovo();
            Console.WriteLine($"{numeroPedido} - {nomeCliente} - {valorPedido}");
            Barra();
        }

        public static Tuple<int, string, double> RetornarPedidosAntigo()
        {
            return new Tuple<int, string, double>(1, "Paulo", 15.95);
        }

        public static(int numeroPedido, string NomeCliente, double valorPedido) RetornarPedidosNovo()
        {
            return (1, "Paulo", 15.95);
        }

        public static void Descartes()
        {
            Barra();
            var (numeroPedido, _, valorPedido) = RetornarPedidosNovo();
            Console.WriteLine($"{numeroPedido} - {valorPedido}");
            Barra();
        }


        public static void Barra()
        {
            Console.WriteLine("============================================================================");
        }
    }
}
