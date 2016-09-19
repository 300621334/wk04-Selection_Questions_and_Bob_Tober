using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My name is Mani Shaikh ";

            //To snip-off from 3rd char then show 12th char aft the first char showing:
            //myString = myString.Substring(3,12);


            //()at the end  indicates a call to constructor method.
            //myString = myString.ToUpper();

            //To replace empty spaces by "--". Make sure there is a space inside " ". If u put "" then error.
            //myString = myString.Replace(" ", "--");


            /*myString.trim generates a string hence () is put after trim. But .Length generates int hence no ().
            trim() clips off empty spaces before and at the end of string*/
            myString = string.Format("Length Before Trimming Blank Spaces: {0}--After Trimming:{1}", myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
