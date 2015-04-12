using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human vlatko = new Human("Vladimir", "Totocevski");            
            Console.WriteLine(vlatko.PrintWelcomeMessage("Dobredojde", "Gospodine"));
            Console.WriteLine(vlatko.IsFullNameLongerThanMaxLength(5));
            Console.ReadLine();
        }
    }
}
