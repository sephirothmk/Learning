using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola3
{
    class Shape
    {
        private static string Name
        {
            get { return string.Format("Square"); }
            set { throw new NotImplementedException(); }
        }

        public static string PrintShapeName()
        {
            return Name;
        }
    }

    class Square : Shape
    {
        public double SideLength { get; set; }
    }
    class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
    }
}
