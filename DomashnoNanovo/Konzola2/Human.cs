using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola2
{
    class Human
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string MiddleName { get; set; }

        public Human(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public Human(string first, string last, string middle) :this(first, last)
        {
            MiddleName = middle;
        }
       
        private string FullName
        {
            get { return String.Format(FirstName + " " + LastName);} 
        }

        public string PrintWelcomeMessage(string message, string message2)
        {
            return String.Format("{0} {1} {2} {3}", message, message2, FirstName, LastName);
        }

        public bool IsFullNameLongerThanMaxLength(int max)
        {
            if (FullName.Length > max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
