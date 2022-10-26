// Write a C program to print all even numbers between 1 to 100
using System;
namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            int b = 1;
            for(int i = 1; i <= 100; i++)
            {
                b=i% 2;
                if (b == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}