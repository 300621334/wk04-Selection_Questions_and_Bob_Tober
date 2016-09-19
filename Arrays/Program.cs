using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Long way of writing arrays:
            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //To display a particular element out of array:            
            //Console.WriteLine(numbers[1]);
            //--or--
            //Console.WriteLine(numbers[1].ToString());


            //Short hand way
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //To display how many elements in array in total:
            //Console.WriteLine(numbers.Length);


            //Loop used to count how many elements in an array:
            //for (int i = 0; i < numbers.Length; i++)
            //{ Console.WriteLine(numbers[i].ToString()); }


            ////Array of strings:
            //string[] names = {"Pervaiz", "Yasmin","Mani","Rabia","Zahra", "Munazah", "Zoya", "Arham"};
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //    //with above ReadLine, u have to press enter repeatedly to show all names one by one. Without it all names show up at once.


            //2 sentences catenated. then converted to array of chars. then reversed.
            string twoSentences = "I was going " + "to school once.";
            char[] arrayOfChars = twoSentences.ToCharArray();
            Array.Reverse(arrayOfChars);
            foreach (char letters in arrayOfChars)
            {
                Console.Write(letters);
                
            }



        
            
        }
    }
}
