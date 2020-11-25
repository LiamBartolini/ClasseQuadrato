using System;
using Bartolini.Liam._4H.ClasseQuadrato.Models;

namespace Bartolini.Liam._4H.ClasseQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q1 = new Q(2, 1, 2);
            Q q2 = new Q(4, 1, 2);

            Console.WriteLine("QUADRATO 1: ");
            Console.WriteLine($"{q1.Area:n2}\tcm^2 \n{q1.Perimetro:n2}\tcm \n{q1.Diagonale:n2}\tcm");

            Console.WriteLine("\nQUADRATO 2: ");
            Console.WriteLine($"{q2.Area:n2}\tcm^2 \n{q2.Diagonale:n2}\tcm \n{q2.Diagonale:n2}\tcm");

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