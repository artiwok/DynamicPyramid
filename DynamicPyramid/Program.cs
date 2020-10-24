﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // DynamicPyramid
            //   *  
            //  ***
            // *****


            Console.Write("Enter height: ");

            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
