using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square
    {
        public double Side { get; set; }

        public double Area
        {
            get { return Side*Side; }
            set { throw new NotImplementedException(); }
        }

        public double Perimeter
        {
            get { return Side*4; }
            set { throw new NotImplementedException(); }
        }
    }

    internal class Rectangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Area
        {
            get { return SideA * SideB; }
            set { throw new NotImplementedException(); }
        }

        public double Perimeter
        {
            get { return (SideA * 2) + (SideB*2); }
            set { throw new NotImplementedException(); }
        }
        public double Diagonal
        {
            get { return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)); }
            set { throw new NotImplementedException(); }
        }
        public double LongerSide
        {
            get { return SideA > SideB ? SideA : SideB;}
            set { throw new NotImplementedException(); }
        }
    }
}