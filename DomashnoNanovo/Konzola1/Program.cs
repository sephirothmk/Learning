using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human vlatko = new Human {FirstName = "Vladimir", LastName = "Totocevski"};
            Console.WriteLine(vlatko.GetFullName());
            Console.ReadLine();
        }
    }
}
