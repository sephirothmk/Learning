using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Konzola3
{
    class Person
    {
        public static string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }

        public Person(string first, string last, string id)
        {
            FirstName = first;
            LastName = last;
            IDNumber = id;
        }
    }

    class Baker:Person, IIsASeller
    {
        public string Sell()
        {
            return String.Format("{0} prodade na {1} edno parce", Baker.FirstName, Customer.FirstName);
        }

        public Baker(string first, string last, string id) : base(first, last, id)
        {
        }
    }

    class Seller: Person, IIsASeller
    {
        public string Sell()
        {
            return String.Format("{0} prodade na {1} edno parce {2}", Baker.FirstName, Customer.FirstName);
        }

        public Seller(string first, string last, string id) : base(first, last, id)
        {
        }
    }

    interface IIsASeller
    {
        string Sell();
    }

    class Customer : Person
    {
        public Customer(string first, string last, string id) : base(first, last, id)
        {
        }
    }
}
