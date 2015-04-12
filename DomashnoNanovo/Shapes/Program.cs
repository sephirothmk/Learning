using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square kvadrat = new Square {Side = 6};
            Console.WriteLine("PLostinata e {0}, a perimetarot e {1}", kvadrat.Area, kvadrat.Perimeter);

            Rectangle pravoagolnik = new Rectangle {SideA = 8, SideB = 5};
            Console.WriteLine("Plostianta e {0}, perimetarot e {1}, dijagonalata e {2}, a pogolemata strana e {3}", pravoagolnik.Area, pravoagolnik.Perimeter, pravoagolnik.Diagonal, pravoagolnik.LongerSide);
            Program.PrintArea(pravoagolnik, 4);
            Console.WriteLine(Program.BiggerPerimeter(kvadrat, pravoagolnik));
            Console.ReadLine();
        }

        static void PrintArea(Rectangle prav, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(prav.Area);
            }
        }

        static double BiggerPerimeter(Square sq, Rectangle prav)
        {
            if (sq.Perimeter > prav.Perimeter)
                return sq.Perimeter;
            else
            {
                return prav.Perimeter;
            }
        }
    }
}
