using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {







            Console.WriteLine("Please enter first number between 1 and 4");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number between 1 and 4");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number between 1 and 4");
            int c = Convert.ToInt32(Console.ReadLine());



            Random r = new Random();
            int n1 = r.Next(1,5);
            int n2 = r.Next(1,5);
            int n3 = r.Next(1,5);





            /*No need to assign value to oneMatch etc because if-else block that uses them does not end in "else-if" 
            rather in "else" only.*/


            /*won had to be given a value because last else-if block is NOT ending with "else" rather with "else if". 
             *So C# assumes that if none of those else-if got executed then what will C# assign to int won!!?? it's a problem. That's why we have to give it a default value.*/

            string aMatch = "";
            string bMatch = "";
            string cMatch = "";


            if (a == n1)
            { aMatch = "x"; }
            else if (a == n2)
            { aMatch = "y"; }
            else if (a == n3)
            { aMatch = "z"; }

            if (b == n1 && aMatch != "x")
            { bMatch = "x"; }
            else if (b == n2 && aMatch != "y")
            { bMatch = "y"; }
            else if (b == n3 && aMatch != "z")
            { bMatch = "z"; }
            if (c == n1 && aMatch != "x" && bMatch != "x")
            { cMatch = "x"; }
            else if (c == n2 && aMatch != "y" && bMatch != "y")
            { cMatch = "y"; }
            else if (c == n3 && aMatch != "z" && bMatch != "z")
            { cMatch = "z"; }

            Console.WriteLine("You entered {0}, {1}, {2}", a, b, c);
            Console.WriteLine("Computer entered {0}, {1}, {2}", n1, n2, n3);

            string matches = aMatch + bMatch + cMatch;
            int howManyMatches = matches.Length;
            if (aMatch == "x" && bMatch == "y" && cMatch == "z")
            { Console.WriteLine("You won $10,000"); }
            else if (howManyMatches == 1)
            { Console.WriteLine("You won $10"); }
            else if (howManyMatches == 2)
            { Console.WriteLine("You won $100"); }
            else if (howManyMatches == 3)
            { Console.WriteLine("You won $1000"); }
            else if (howManyMatches == 0)
            { Console.WriteLine("Sorry you did not win, try again."); }






        }
    }
}
