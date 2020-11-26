using System;
using Bartolini.Liam._4H.ClasseQuadrato.Models;

namespace Bartolini.Liam._4H.ClasseQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q1 = new Q(4, -2, 1);
            Q q2 = new Q(7, 4, 2);

            Console.WriteLine("QUADRATO 1: ");
            Console.WriteLine($"Area: \t\t{q1.Area:n2}\tcm^2 \nPerimetro: \t{q1.Perimetro:n2}\tcm \nDiagonale: \t{q1.Diagonale:n2}\tcm");

            Console.WriteLine("\nQUADRATO 2: ");
            Console.WriteLine($"Area: \t\t{q2.Area:n2}\tcm^2 \nPerimetro: \t{q2.Perimetro:n2}\tcm \nDiagonale: \t{q2.Diagonale:n2}\tcm");

            Console.Write("\nQuadrato 1 < Quadrato 2:");
            Console.Write($"\t{q1 < q2}");
            
            Console.Write("\nQuadrato 1 > Quadrato 2:");
            Console.Write($"\t{q1 > q2}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\nEsito Intersezione quadrati: \n{Q.Intersezione(q1, q2)}");
            Console.ResetColor();
        }
    }
}