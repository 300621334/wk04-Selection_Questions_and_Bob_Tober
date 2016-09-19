using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type rock, paper, or scissors…");
            string user = Console.ReadLine();
            Random r = new Random();
            int computer = r.Next(4);
            if (computer == 1)
            {
                if (user == "rock")
                {
                    Console.WriteLine("You chose rock, computer chose rock, so it’s a tie.");
                }
                else if (user == "paper")
                {
                    Console.WriteLine("You chose paper, computer chose rock, so you win.");
                }
                else if (user == "scissors")
                {
                    Console.WriteLine("You chose scissors, computer chose rock, so you lose.");
                }
                else
                {
                    Console.WriteLine("Your entry was incorrect.");
                }
            }
            if (computer == 2)
            {
                if (user == "rock")
                {
                    Console.WriteLine("You chose rock, computer chose paper, so you lose.");
                }
                else if (user == "paper")
                {
                    Console.WriteLine("You chose paper, computer chose paper, so it’s a tie.");
                }
                else if (user == "scissors")
                {
                    Console.WriteLine("You chose scissors, computer chose paper, so you win.");
                }
                else
                {
                    Console.WriteLine("Your entry was incorrect.");
                }
            }
            if (computer == 3)
            {
                if (user == "rock")
                {
                    Console.WriteLine("You chose rock, computer chose scissors, so you win.");
                }
                else if (user == "paper")
                {
                    Console.WriteLine("You chose paper, computer chose scissors, so you lose.");
                }
                else if (user == "scissors")
                {
                    Console.WriteLine("You chose scissors, computer chose scissors, so it’s a tie.");
                }
                else
                {
                    Console.WriteLine("Your entry was incorrect.");
                }
            }


        }
    }
}
