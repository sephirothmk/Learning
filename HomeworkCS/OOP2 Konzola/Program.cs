using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace OOP2_Konzola
{
    static class Program
    {
        static void Main(string[] args)
        {
            var vladimir = new Human("Vladimir", "Totocevski");
            var welcome = vladimir.PrintWelcomeMessage("Dobre ni dojde", "Dobro ne najde");
            Console.WriteLine(welcome);

            var daliE = vladimir.IsFullNameLongerThanMaxLentgh(6);
            Console.WriteLine(daliE);           

            // I ovde ne razbiram sto treba da napravam za bonusite.

            var vladimir2 = new Human("Vladimir", "Totocevski", "Jebo Fakic");
            var pozdrav = vladimir2.GetFullName();
            Console.WriteLine(pozdrav);
            Console.ReadLine();
        }
    }
}
