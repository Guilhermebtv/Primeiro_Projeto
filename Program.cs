using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetCursorPosition(45, 10);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" MEU ");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" PRIMEIRO ");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" PROJETO ");

            Console.ReadKey();
        }
    }
}
