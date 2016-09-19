using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4_decisions
{
    class Program
    {
        //enum DAYS_OF_WEEK { MON=1, TUES, WED, THURS, FRI, SAT, SUN}
        static void Main(string[] args)
        {
            /*if curly braces r NOT used, only one statemnet just next to is conditional, 
            subsequent statements r independent. if-statemnet actually ends at semi-colon if ther's no
            "block" { }, but if there's a block aft if-stat then it ends at the end-of-block*/
            //int a = 5;
            //if (a < 5) Console.WriteLine("A");
            //Console.WriteLine("B");

            //if(number>LOW)if(number<HIGH)Console.WriteLine("{0} is between {1} and {2}",number,LOW,HIGH);

            /*if argument can ONLY result in bool. We can only assign a bool value to a variable inside 
            a "tested-expression" e.g. if(hasDependents= numOfDependents>0);
            ---e.g.---
            int a = 5, num;
            string b = "abc";
            bool c = int.TryParse(b, out num);
            if (a > 2 && c) Console.WriteLine("we r good");
            else Console.WriteLine("there's a problem");*/


            /*&& || r "conditional" AND/OR ops. & | r "logical" AND/OR ops.
            in && if 1st tested-exp is false, it never evaluates the 2nd tested-exp.
            where-as in "&" both bool-exp r tested before decision is made. 
            "logical" AND/OR ops can give wrong outcome in following ex.
            if(salesAmountForYear >= 10000 & ++yearsOfService > 10)bonus = 200;
            
            if mor than one && || r used, && takes precedence, so if left of && is false ten right of && is not
            even evaluated and ignored. Use brackets to enforce || to evaluate first
            e.g
            if((age <= 12 || age >= 65) && rating == 'G') Console.WriteLine("Discount applies");*/

            //enumeration with switch>>read from p-165 of book
            //Console.WriteLine("Enter number for day of the week");
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch((DAYS_OF_WEEK)day)
            //{
            //    case DAYS_OF_WEEK.MON:
            //        Console.WriteLine("Monday");
            //        break;
            //    case DAYS_OF_WEEK.TUES:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case DAYS_OF_WEEK.WED:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case DAYS_OF_WEEK.THURS:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case DAYS_OF_WEEK.FRI:
            //        Console.WriteLine("Friday");
            //        break;
            //    default:
            //        Console.WriteLine("Weekend");
            //        break;

            //}



            //alternate to if/else is "conditional operator" is the only ternary op. use 3 operands. 
            //tested-expression then "?" then if-true answer then ":" then if-false answer. Both sides have to be same data type.
            //int score = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((score>=60)? "PASSed":"FAILed");

            //            Augustus de Morgan was a 19th - century mathematician who originally
            //  observed the following:
            //!(a && b) is equivalent to !a || !b
            //!(a || b) is equivalent to !(a && b)


            //an example of how to use "add & assign" += in GUI:
//            outputLabel.Text = String.Format("When age is {0} and rating is {1}",
//age, rating);
//            if ((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
//                outputLabel.Text += "\nDiscount applies";
//            else
//                outputLabel.Text += "\nFull price";































        }
    }
}
