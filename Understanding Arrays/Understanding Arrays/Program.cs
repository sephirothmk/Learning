using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //string[] iminja = new string[] { "Vlatko", "Tose", "Mitko", "Gele" };
            //foreach (string ime in iminja)
            //{
            //    Console.WriteLine(ime);
            //}
            //Console.ReadLine();

            string zig = "Ebeme sve site ste pederi da vi ebam" +
            "majkata u picka na site u gz so lazica";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();


        }
    }
}
