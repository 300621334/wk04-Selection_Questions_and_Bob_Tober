using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfCompareToEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Matthew";
            Console.WriteLine("Using Equals() method");
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name2, String.Equals(name1, name2));
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name3, String.Equals(name1, name3));
            Console.WriteLine("Using Compare() method");
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name2, String.Compare(name1, name2));
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name3, String.Compare(name1, name3));
            Console.WriteLine("Using CompareTo() method");
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name2, name1.CompareTo(name2));
            Console.WriteLine("compare {0} to {1}: {2}",
            name1, name3, name1.CompareTo(name3));




        }
    }
}
