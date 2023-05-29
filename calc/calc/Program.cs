using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x, y;
            char z;
            Console.WriteLine("Привет!");
            Console.WriteLine("Введите первую переменную: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие: +, -, *, /");
            z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
            y = Convert.ToDouble(Console.ReadLine());
            

            switch (z)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", x, y, x + y);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", x, y, x - y);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", x, y, x * y);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", x, y, x / y);
                    break;
                default:
                    Console.WriteLine("Отмена");
                    break;
            }
            Console.WriteLine("Завершить работу программу (Y / N)");
            Console.ReadLine();
           
        }
    }
}