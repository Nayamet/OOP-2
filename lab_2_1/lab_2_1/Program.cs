﻿using System;

namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {   //problem 1
            Console.Write("Even number between 1-50 : ");
            for(int i=1;i<=50;i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            //problem 2
            for (int i=1;i<5;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("0X0X0X");
                }
                else
                    Console.WriteLine("X0X0X0");
            }
            Console.WriteLine();
            //problem 3 
            for (int k=1;k<=5;k++)
            {
                for(int j=k;j<k+5;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //problem 4
            Console.WriteLine();
            int sum1=0, sum2=0;
            for(int i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    sum1 = sum1 + i;
                }
                else
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine("Sum of odd number (1-100): " + sum2);
            Console.WriteLine("Sum of even number(1-100) : " + sum1);
            Console.WriteLine();
            //problem 5
            for (int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                for(int l=0;l<i;l++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //problem 6
            int a = 5,sum=1;
            for(int i=5;i>0;i--)
            {
                sum = sum * i;
            }
            Console.WriteLine(a + "! = " + sum);
            Console.WriteLine();
            //problem 7
            for (int i = 1; i <= 5; i++)
            {
               
                for (int l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i>0; i--)
            {

                for (int l = i; l >0; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
