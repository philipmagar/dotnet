using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Swapping values of two variables without using the third variable
            int first_variable = 5;
            int second_variable = 10;
            Console.WriteLine("Before Swapping:");
            Console.WriteLine("First_variable=" + first_variable);
            Console.WriteLine("Second_variable=" + second_variable);
            first_variable = first_variable * second_variable;
            second_variable = first_variable / second_variable;
            first_variable = first_variable / second_variable;
            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("First_variable=" + first_variable);
            Console.WriteLine("Second_variable=" + second_variable);
    
        }
    }
}
