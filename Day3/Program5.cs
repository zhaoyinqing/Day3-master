using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program5
    {
        static void Main()
        {
            Random r = new Random();//pick a number 1-9
            double  secretNum = r.Next(1, 10); // this doesn't work -> Random.Next
            bool correctGuess = false; //indicate that user has enter the correct guess 
            while (correctGuess == false)//while user has not guess correctly
            {
                Console.Write("Enter your guess: "); //ask user for a  guess
                string input = Console.ReadLine();
                if (input == secretNum.ToString()) //if guess is correct
                { 
                    Console.WriteLine("Congrats!");//congrats
                    correctGuess = true;
                }
                else
                { 
                    Console.WriteLine("Wrong guess. Try again.");//else//say wrong guess  
                }
            }

        }
    }
}
