using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestWorldAgain.Model;

namespace TestWorldAgain {
    class Program {

        static List<Person> people { get; set; }

        static void Main(string[] args) {
            people = new List<Person>();
            foreach(Person p in people) {
                Console.WriteLine(p.name + " " + p.age);
            }
            Console.ReadLine();
        }
    }
}
