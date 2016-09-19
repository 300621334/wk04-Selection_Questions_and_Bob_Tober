using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingData_chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting a constant(int by default) to double(floating point) by using D or d. 
            //Otherwise int/int will discard decimal places.
            //Console.WriteLine(4d/3+2);

            //int b = 4;
            //int c = b++; //assign b to c before increasing b by 1.
            //c = ++b; //increases b by 1 & then assigns new value to c.
            //increment op ++b, decrement --b.
            //add&assign += no space, sub&ass -=, div&ass /=, *=.
            //modlus/remainder op cannot be used with floating-pt coz ans is in decimal & NO remainder.
            //formatted string is a sring with place-holders i.e string that will display aft being formatted.
            /*numeral-format-string is same as above + format-specifiers:c, :f, :n, :E(exponent=scientific notation) 
            :r (retain value when re-converted to int), :x(hexadecimal), :p(%) :(###)-###-#### etc inside place-holders.*/
            //Format-specifiers can be used as (for 3 decimals & $ sign & commas) >>> Console.WriteLine(variable.ToString("C3"));
            //{0, 5} or {0, -5} place holders will reserve 5 character spaces for value {0} & RIGHT/LEFT align in display.

            //Console.WriteLine(7/2); //2 int so and is 3.
            //Console.WriteLine(7d / 2); //casted an int into a double so ans is 3.5 ('0' of 3.50 omitted to give most compact reply)

            /*double c = 7 / 2;  Console.WriteLine(c); //7 & 2 r int by default, so decimal is dropped from ans before ans is assigned to 
            a double "c".!*/



            //Below,, 'c' will be 3.5 coz 7 was declared double BEFORE div by 2 -same with- d (casting).
            //int a =1, b=7/2; double c = 7d / 2, d = (double)7 / 2; 
            //implicit casting of int to double.
            //Console.WriteLine( "ans e no implicit casting: {0}, ans e one: {1}", a*b, a*c);
            //explicit casting of double into int
            //Console.WriteLine("Without casting into int {0}, & with casting {1}, & using 'd' {2}", a*c, a*(int)c, a*d);

            //Below, 2nd statement, first casting is done THEN div by 2.
            //double a = 5d / 2;
            //double c = (int)a / 2.5;
            //Console.WriteLine(c);


            //Can convert int-to-double --BUT-- not the other way around.
            //int a = 2;
            //double b = a;
            //int c = b; //error

            //Using "escape sequence" we can store non-printing characters as "BackSpace" as '\b' & "Tab" as '\t' in char.
            //"escape sequence" represents a unique value of character(b, t) instead of character themselves.

            //Equals("Mani", "mani") gives bool (True/False).
            //Console.WriteLine(String.Equals("Mani", "mani").ToString());
            //static-method of Compare("mani", "Mani") gives integer value of -1, 0, or 1. Static coz it doesn't need object before it to be called.
            //Console.WriteLine(String.Compare("mani", "Mani"));
            //non-static(instance)Methods like mani.ToCompare("Mani") need an object(=an instance "name" of a class "string") then dot, to be called. It also returns integer -1,0, or 1.
            //string name = "mani"; Console.WriteLine(name.CompareTo("Mani"));


            //differentiate b/w numbers/letters:
            //Console.WriteLine("Please enter any number");
            //int num;
            ////if user enter letters "out" will give zero "0" plus returns "False".
            //bool entry = int.TryParse(Console.ReadLine(), out num);
            //if (entry == false)
            //{Console.WriteLine("aey ki enter kar ditta ay!!!!!!");}
            //else{int remainder = num % 2; if (remainder == 0){Console.WriteLine("you entered an even number");}
            //else if (remainder == 1){Console.WriteLine("you entered an odd number");}}

            /*to detect whether user entreed numbers or letters, see following example. 
        Try.Parse generates 2 outputs; one is a TRUE/False & other is an "out" that we maychoose to use or ignore.*/
            //string str = "123";
            //int num1;
            //bool n = int.TryParse(str, out num1);
            //Console.WriteLine(num1);
            //Console.WriteLine(n);
            //Console.ReadLine();


            //sub-string method returns a string. Extracts part of a string. 1st# in bracket is start point of desired string-fragment, 2nd# is how many characters u want.
            //string word = "i am going to college";
            //Console.WriteLine(word.Substring(0, word.Length-1));
            //Console.WriteLine(word.Substring(2, 2));
            //Console.WriteLine(word.Substring(5, 8));

            //StartsWith() returns true/false.
            //string name = "Mani";
            //Console.WriteLine(name.StartsWith("Ma"));

            //thou not really needed, identifiers assigned to constants are NOT vari-ables. i.e. cannot change em. Conventionally use all-CAPs.
            //const double TAX_RATE = 0.06, INCHES_IN_A_FOOT = 12;//self-documenting identifiers.

            //Enumeration "enum" is a list of constants; goes outside Method, inside Class; all-CAP identifier.
            //Read from page-78 of book.





        }
    }                                                                                                                            s
}