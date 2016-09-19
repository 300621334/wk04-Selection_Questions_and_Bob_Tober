using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useOfBackSlash
{
    class Program
    {
        static void Main(string[] args)
        {
            /*back-slash and double-quotes won't show in a string. need to put another back-slash behind them.
            \n produces a new line. What follows string.Format below could just be written in console.writeLine too.*/
            //string myString = "Go to C:\\ drive";
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need\na new line!";
            //string myString = string.Format("Make {0}, Model {1}", "Honda", "1997");



            //Console.WriteLine("Make {0}, Model {1}", "Honda", "1997");


            /*:N cap or small, puts comma q 3 digits and 2 decimals.
            :P cap or small, puts % sign and 2 decimal places.
            (###) ###-#### gives phone# format*/
            //string myString = string.Format("{0:n}",123456789);
            //string myString = string.Format("{0:p}", 123456789);
            string myString = string.Format("{0:###-###-####}", 1234567890);

            Console.WriteLine(myString);





        }
    }
}
