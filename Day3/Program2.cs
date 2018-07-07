using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        static void Main() //a program that ask for password
            //the password is ISS
            //if the person give wrong password 3 times, 
            //the system will be locked
        {
            bool correctPwd = false; //repeat 3 times//for (int i = 1; i <= 3; i++)
            for (int i = 0; i < 3; i++)
            {  
                Console.Write("Enter password: ");//  ask for password
                string input = Console.ReadLine(); 
                if (input == "ISS")//  if password correct
                { 
                    correctPwd = true;//    set the flag to true
                    Console.WriteLine("Congratulation!"); //    say Congrats
                    break;   //    exit repetition
                }
                else
                {
                    Console.WriteLine("Password Incorrect");
                }
            }

            if (correctPwd == false)
            {
                Console.WriteLine("Game Over.");
            }
        }
    }
}
