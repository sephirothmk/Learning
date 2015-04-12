using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Human
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public string MiddleName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Human(string firstName, string lastName, string middleName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }

        public string GetFullName()
        {
            return String.Format("Hi, my name is {0} {1} {2}", FirstName, MiddleName, LastName);
        }

        public string PrintWelcomeMessage(string welcomeMessage1, string welcomeMessage2)
        {
            return welcomeMessage1 + " " + welcomeMessage2 + " " + this.FirstName + " " + this.LastName;
        }

        public bool IsFullNameLongerThanMaxLentgh(int maxLentgh)
        {
            var name = this.FirstName + this.LastName;
            if (name.Length > maxLentgh)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Square
    {
        private int SideLenght { get; set; }

        public Square(int side)
        {
            this.SideLenght = side;
        }

        public int CalculateArea()
        {
            return this.SideLenght*this.SideLenght;
        }

        public int CalculatePerimeter()
        {
            return this.SideLenght*4;
        }
    }

    public class Rectangle
    {
        private double SideA { get; set; }
        private double SideB { get; set; }

        public Rectangle(double prvastrana, double vtorastrana)
        {
            this.SideA = prvastrana;
            this.SideB = vtorastrana;
        }

        public double CalculateArea()
        {
            return this.SideA*this.SideB;
        }

        public double CalculatePerimeter()
        {
            return 2*this.SideA + 2*this.SideB;
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2));
        }

        public double LongerSide()
        {
            if(this.SideA > this.SideB)
            {
                return this.SideA;
            }
            else
            {
                return this.SideB;
            }
        }
    }

    public class Shape
    {
        internal string Name { get; set; }

        public Shape()
        {
            Name = "Square";
        }

        public string PrintShapeName()
        {
            return Name;
        }
    }

    public static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double SquareRoot(double a)
        {
            return Math.Pow(a, 2);
        }

        static Calculator()
        {
            //Ne mi davase public da bide
        }
    }

    public class Kvadrat : Shape
    {
        private double SideLength { get; set; }

        public Kvadrat(string ime, double lenght)
        {
            this.Name = ime;
            this.SideLength = lenght;
        }
    }

    public class Pravoagolnik : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        public Pravoagolnik(string ime, double sidea, double sideb)
        {
            this.Name = ime;
            this.SideA = sidea;
            this.SideB = sideb;
        }

    }

    public class Person
    {
        public static string Name { get; set; }
        public string LastName { get; set; }
        public double IdNumber { get; set; }

    }

    public class Baker : Person
    {
        public Baker(string ime)
        {
            Baker.Name = ime;
        }
        public void Sell()
        {
            Console.WriteLine("{0} prodade na {1} edno parce {2}", Person.Name, Customer.Name, Product.Name);
        }
    }

    public class Seller : Person
    {
        public Seller(string ime)
        {
            Seller.Name = ime;
        }
        public void Sell()
        {
            Console.WriteLine("{0} prodade na {1} edno parce {2}", Person.Name, Customer.Name, Product.Name);
        }
    }

    public class Customer : Person
    {
        public void Customer(string ime)
        {
            Customer.Name = ime;
        }
    }

    public abstract class Product
    {
        public static string Name { get; set; }
    }

    public class Bread : Product
    {
        
    }
    public class Pizza : Product
    {

    }
    public class PizzaRoll : Product
    {

    }
    public class Burek : Product
    {

    }
    
}
