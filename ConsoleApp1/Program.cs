using System;

namespace ConsoleApp1
{
    class Program
    {
        static double add(double a, double b) {
            return a + b;
        }
        static double sub(double a, double b)
        {
            return a - b;
        }
        static double mul(double a, double b)
        {
            return a * b;
        }
        static double div(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double total = 0;
            char oper;

            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = add(a, b);    
            }

            else if (oper == '-')
            {
                total = sub(a, b);
                
            }

            else if (oper == '*')
            {
                total = mul(a, b);
                
            }

            else if(oper == '/')
            {
                total = div(a, b);
                
            }
            else
            {
                Console.WriteLine("Неизвестный оператор");
                oper = '!';
            }
            if (oper != '!')
            {
                Console.WriteLine("Результат: "+ total);
            }
        }
    }
}