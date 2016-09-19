using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopStringCatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "";


            //for (int i = 0; i < 100; i++)
            //{
            //    //String = myString + "--" + i.ToString();
            //    //Can also be:
            //    //myString = myString + "--" + Convert.ToString(i);

            //    //second way to catenate/append is, no-space b/w +=  :
            //    //myString += "--" + i.ToString();
            //}
        

            //third & faster way (coz doesn't assign new value to myString repeatedly) is using "stringBuilder":
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
                Console.WriteLine(myString);




        }
    }
}
