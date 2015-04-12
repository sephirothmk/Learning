using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Napishi nesto kloshar");
            string shoNapishal = Console.ReadLine();
            Console.WriteLine("Ti napisha: " + shoNapishal);
            Console.ReadLine();
            */

            Console.WriteLine("Sakas da ja otvoris vratata pod broj 1,2 ili 3?");
            string vrata = Console.ReadLine();
            //string poraka = "";
            //if (vrata == "1")
            //    poraka = "Si dobi nova kola";
            //else if (vrata == "2")
            //    poraka = "Si dobi kur u gz";
            //else if (vrata == "3")
            //    poraka = "aj ne jadi gomna";
            //else
            //    poraka = "Vnese pogresen izbor";                           
            //Console.WriteLine(poraka);

            string poraka = (vrata =="1") ? "Boat" : "strand of lint";
            Console.WriteLine("Dobi {0}", poraka);

            Console.ReadLine();
        }
    }
}
