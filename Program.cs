using System;
namespace Aula22Static
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Conversão de Valores em Dolar:");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Conversor.CotacaoDolar = 5.29f;
            Console.WriteLine( Conversor.DolarParaReal(23) );
            Console.WriteLine( Conversor.RealParaDolar(23) );

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Conversão de Valores em Euro:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;

            Conversor.CotacaoEuro = 5.90f;
            Console.WriteLine( Conversor.EuroParaReal(23) );
            Console.WriteLine( Conversor.RealParaEuro(23) );

            Console.ResetColor();
        }
    }
}
