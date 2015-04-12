using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine(Shape.PrintShapeName());
            Console.WriteLine(Calculator.Suma(5,9));
            Console.WriteLine(Calculator.SquareRoot(144));

            Square kvadrat = new Square {SideLength = 6};
            Console.WriteLine(Square.PrintShapeName()); //Si go nasleduva imeto od Shape
            Rectangle pravoagolnik = new Rectangle {SideA = 5, SideB = 7};
            Console.WriteLine(Rectangle.PrintShapeName()); //Si go nasleduva imeto od Shape
            Shape test = new Shape(); //Ovoj objekt nema properties sho gi imaat negovite deca

            Baker burekcija = new Baker("Stanko", "Stankovski", "0234234");
            Seller prodavac = new Seller("Ivan", "Ivanovski", "346546");
            Customer klient = new Customer("Vladimir", "Totocevski", "22343");
            Console.WriteLine(burekcija.Sell());
            Console.ReadLine();
        }
    }
}
