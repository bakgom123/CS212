/*********************************************************************
* cs 212: program01 Lg Lg n
* This is he simple C# program(command-sehll program) that computes the floor(lg lg n) without any special math library functions.
*
* David Yoo (gy24)
* 09/12/2022
*
*********************************************************************/
using System;
namespace Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the program to calculate the floor of lg(lg(n))!");
            while (true)
            {
                Console.Write("\nEnter N: ");
                long n = long.Parse(Console.ReadLine());
                long res1 = Floor(n);
                long res2 = Floor(res1);
                Console.WriteLine("Floor of Lg(Lg({0})) = {1}.", n, res2);
            }
        }
        /*
         * This is the function to calculate the floor of the log (base 2) 
         */
        static long Floor(long n)
        {
            int i = 0;
            while (n > 1)
            {
                n /= 2;
                i++;
            }
            return i;
        }
    }
}