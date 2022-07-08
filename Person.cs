using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hello Wajid
namespace Multitreading
{
    class Person
    {

        public string Fname { get; set; }
        public string Lname { get; set; }

        public Person()
        {
            Fname = "wajid";
            Lname = "shaikh";
        }
        public Person(string f, string l )
        {
            Fname = f;
            Lname = l;
        }
        ~Person()    
        {
            Console.WriteLine("Hii from Gc");

        }
    }
}
