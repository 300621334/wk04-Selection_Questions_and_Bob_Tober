using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlignFormatStringFormatItems
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare in same line:
            int num1, num2, num3; //or int num1=123,num2=1234,num3=12345;

            num1 = 123; num2 = 1234; num3 = 12345;

            //numbers are LEFT alighed.
            //Console.WriteLine("{0}", num1);
            //Console.WriteLine("{0}", num2);
            //Console.WriteLine("{0}", num3);

            /*To RIGHT align, after placeholder(Format Item) specify a space of so-many characters and to alight numbers to RIGHT; 
            a minus sign will LEFT align,*/
            //Console.WriteLine("{0, 6}", num1);
            //Console.WriteLine("{0, 6}", num2);
            //Console.WriteLine("{0, 6}", num3);
            //Console.WriteLine("{0, -6}", num1);
            //Console.WriteLine("{0, -6}", num2);
            //Console.WriteLine("{0, -6}", num3);


            //can split a statement after a comma etc, NOT in middle of string. Or catenate 2 strings & aft + wrap to next line.
            /*Console.Write("I am goint to split this statement in to lines after coma before {0}, {1}, {2}",
                num1, num2, num3);*/
            /*Console.WriteLine("I am goint to split this statement by "+
            "catenation {0}, {1}, {2}", num1, num2, num3);*/


            /*unicode letters & even punctuation r stored as numeric code e.g. char 'A' if stored as 65.
            if we convert char to int it will show that numeric value*/
            char letter = 'A';
            Console.WriteLine((int)letter);




        }
    }
}
