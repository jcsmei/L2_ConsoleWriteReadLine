using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_ConsoleWriteReadLine
{
    class Program
    {
        static void Main()
        {
     
        
                Console.WriteLine("Please enter your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Please enter your last name:");
                string lastName = Console.ReadLine();
                //string variable Name will the value of Console.Readline();

                //Console.WriteLine("Hello, " + firstName + " " + lastName + "!"); //concantenate strings

                Console.WriteLine("Hello, {0} {1}!", firstName, lastName); //place holder syntax

                Console.ReadLine();
            }
        }
    }

