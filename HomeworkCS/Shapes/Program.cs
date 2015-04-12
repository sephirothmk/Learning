using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Shapes
{
    static class Program
    {
        static void Main(string[] args)
        {
            var kocka = new Square(6);
            var plostina = kocka.CalculateArea();
            var obikolka = kocka.CalculatePerimeter();

            Console.WriteLine("Plostinata e {0}, a obikolkata {1}", plostina, obikolka);
           
            var pravoagolnik = new Rectangle(4, 9);
            double plostina2 = pravoagolnik.CalculateArea();
            double obikolka2 = pravoagolnik.CalculatePerimeter();
            var dijagonala = pravoagolnik.CalculateDiagonal();
            var podolgastrana = pravoagolnik.LongerSide();

            Console.WriteLine("Plostinata na pravoagolnikot e {0}, negovata obikolka {1}, dijagonalata mu e {2}, a pogolemata strana mu e {3}", plostina2, obikolka2, dijagonala, podolgastrana);
            Console.ReadLine();
        }

        //Ne mi se bash jasni bonusite od OOP Tasks 1...

        //public static Rectangle PrintArea(Rectangle kvadar, int n)
        //{
        //    if (kvadar == null) throw new ArgumentNullException("kvadar");
        //    for (int i = 0; i <= n; i++)
        //    {
        //        Console.WriteLine("Plostinata e {0}", kvadar);
        //    }
        //}
    }
}
