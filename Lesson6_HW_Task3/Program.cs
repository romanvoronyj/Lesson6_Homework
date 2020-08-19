using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HW_Task3
{
    class Program
    {
        static void Add(ref double operand1, ref double operand2, out double res)
        {
            res = operand1 + operand2;
        }
        static void Sub(ref double operand1, ref double operand2, out double res)
        {
            res = operand1 - operand2;
        }
        static void Mul(ref double operand1, ref double operand2, out double res)
        {
            res = operand1 * operand2;
        }
        static void Div(ref double operand1, ref double operand2, out double res)
        {
            res = operand1 / operand2;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть перше число: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введіть знак арифметичної дії:");
            string sign = Console.ReadLine();
            Console.Write("Введіть друге число: ");
            double y = Double.Parse(Console.ReadLine());

            double res =0;
            switch (sign)
            {
                case "+":
                    {
                        Add(ref x, ref y, out res);
                        Console.WriteLine("Результат складає:{0}",res);
                        break;
                    }
                case "-":
                    {
                        Sub(ref x, ref y, out res);
                        Console.WriteLine("Результат складає:{0}", res);
                        break;
                    }
                case "*":
                    {
                        Mul(ref x, ref y, out res);
                        Console.WriteLine("Результат складає:{0}", res);
                        break;
                    }
                case "/":
                    {
                        Div(ref x, ref y, out res);
                        if (y == 0)
                        {
                            Console.WriteLine("Ділення на 0 заборонено!");
                        }
                        else
                        {
                            Console.WriteLine("Результат складає:{0}", res);
                        }
                        break;
                    }
            }
            Console.ReadKey();


        }
    }
}
