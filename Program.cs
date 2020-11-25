using System;
using Bartolini.Liam._4H.ClasseQuadrato.Models;

namespace Bartolini.Liam._4H.ClasseQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q1 = new Q(7, 7, -2);
            Q q2 = new Q(4, 2, -4);

            Console.WriteLine("QUADRATO 1: ");
            Console.WriteLine($"{q1.Area:n2}\tcm^2");
            Console.WriteLine($"{q1.Perimetro:n2}\tcm");
            Console.WriteLine($"{q1.Diagonale:n2}\tcm");
            
            Console.WriteLine("\nQUADRATO 2: ");
            Console.WriteLine($"{q2.Area:n2}\tcm^2");
            Console.WriteLine($"{q2.Perimetro:n2}\tcm");
            Console.WriteLine($"{q2.Diagonale:n2}\tcm");

            Console.Write("\nQuadrato 1 < Quadrato 2:");
            Console.Write($"\t{q1 < q2}");
            
            Console.Write("\nQuadrato 1 > Quadrato 2:");
            Console.Write($"\t{q1 > q2}");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nEsito Intersezione quadrati: ");

            Console.WriteLine(Q.Intersezione(q1, q2));

            Console.ResetColor();
        }
    }
}