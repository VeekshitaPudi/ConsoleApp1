// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;   
using System.Linq;  
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Git");

            

            for(int i = 0; i < 10; i++)
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("Welcome All!!!");
                for(int j = 0; j < 60; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}