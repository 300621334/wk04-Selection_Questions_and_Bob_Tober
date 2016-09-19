using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingMethodAndCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            //method#2 called if there's a string inside () after method name "combine".
            string callMethod = combine(" sunshine");
            Console.WriteLine(callMethod);
            
            //other overload, with empty lambda expression i.e no args (). It will call method#1.
            //string callMethod = combine();
            //Console.WriteLine(callMethod);
        }


        /*hover over closing curly braces of "class" to confirm it's closing braces for "class", then inside of it
        create 2 overloads(varieties) of a method="combine", one empty(without arguments) second with a string inside
        If empty one is called then it displays "Hello world!". But if one with a string is called it displays
        "Hello" and then whatever string was inside the calling mathod.*/
        


            //method#1 - first overload
        private static string combine()
        {
            return "Hello World!";
        }
        //method#2 - second overload
        private static string combine(string name)
        {
            return "Hello" + name;
            /*one line args works without {} but better put them. return("Hello" + name;) or
            return String.Format("Hello {0}", name)   */
        }

    }
}
