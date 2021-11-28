// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number = 1000;
            // Beginning sequence by printing 0 and 1.
            Console.Write(n1 + " " + n2 + " ");
            /* Loop starts from 2. Sequence loops until counter hits 1000 set by number variable. inside for loop previous 
             * 2 numbers added and then added to n3 which is printed befor re-allocating previous 2 numbers and starting
             * again */
            for (i = 2; i < number; ++i)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}

