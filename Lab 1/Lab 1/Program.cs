using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            double num1 = 15, num2 = 10;
            Console.WriteLine(num1+" + "+num2+" = "+(num1+num2));
            Console.WriteLine();
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine();
            int a = -5 + 8 * 6;
            Console.WriteLine("-5 + 8 * 6"+" = "+a);
            //Console.WriteLine();
            int b = (55 + 9) % 9;
            Console.WriteLine("(55 + 9) % 9" + " = "+b);
            //Console.WriteLine();
            double c = 20 +((-3 * 5) / 8);
            Console.WriteLine("20 + (-3 * 5) / 8" + " = " + c);
            //Console.WriteLine();
            double d = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("5 + 15 / 3 * 2 - 8 % 3" + " = " + d);
            Console.WriteLine();
            double num3=9, num4=2;
            Console.WriteLine("num1 = " + num3);
            Console.WriteLine("num2 = " + num4);
            Console.WriteLine(num3 + " + " + num4 + " = " + (num3 + num4));
            Console.WriteLine(num3 + " - " + num4 + " = " + (num3 - num4));
            Console.WriteLine(num3 + " * " + num4 + " = " + (num3 * num4));
            Console.WriteLine(num3 + " / " + num4 + " = " + (num3 / num4));
            Console.WriteLine(num3 + " % " + num4 + " = " + (num3 % num4));
            Console.WriteLine();
            double temp1 = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("(25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)" + " = " + temp1);
            Console.WriteLine();

            double width = 5.5, height = 8.5;
            Console.WriteLine("Width = "+width);
            Console.WriteLine("Height = " + height);
            Console.WriteLine("Area : " + (width * height));
            Console.WriteLine("Perimeter : " + (2 * (width + height)));



        }
    }
}
