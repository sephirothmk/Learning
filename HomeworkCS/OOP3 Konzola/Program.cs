using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace OOP3_Konzola
{
    static class Program
    {
        static void Main(string[] args)
        {
            var kocka = new Shape();
            //var rezultat = Shape.PrintShapeName();
            // Console.WriteLine(rezultat);
            var rezultatZbir = Calculator.Sum(4, 12);
            var rezultatKvadrat = Calculator.SquareRoot(9);
            Console.WriteLine("Zbirot e {0}, a kvadratot e {1}", rezultatZbir, rezultatKvadrat);
            //var objekt = new Calculator(); nejke novo da kreira dur ne go izbrisham staticot

            var novaKocka = new Kvadrat("Dzordz", 6);
            var novPravoagolnik = new Pravoagolnik("Dzekson", 4, 11);
            var test = new Shape(); //Shape go ima samo Name parametarot, ne gi poseduva parametrite na decata.

            var Pekar = new Baker("Dzoni");
            var Prodavac = new Seller("Dzej");

            var kupuvac1 = new Customer();
            var kupuvac2 = new Customer();

            Prodavac.Sell();

            //Po se izgleda 4tiov del so inheritance ne mi e bash jasen ili instrukciite vo dokumentot se zbunuvacki
            Console.ReadLine();
        }
    }
}
