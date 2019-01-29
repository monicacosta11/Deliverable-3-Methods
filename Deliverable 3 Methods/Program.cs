/*
Author: Monica Costa
Date: 1/28/2019
Comments: This C# Console application code demonstrates the use of
  methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter your first and last name: ");

            try
            {
                //This variable will gather data from user input
                string input = Console.ReadLine();

                Console.WriteLine("Hello " + input + "!");
                Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("There was an error");
                Console.ReadKey(true);
            } //End of catch
        }
    }
}
