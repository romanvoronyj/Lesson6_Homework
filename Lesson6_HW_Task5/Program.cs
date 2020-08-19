using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HW_Task5
{
    class Program
    {
        static void Number (ref int num)
        {
            if(num>0)
            {
                Console.WriteLine("Введене число є додатнім!");
            }
            else
            {
                Console.WriteLine("Введене число є від'ємним!");
            }
        }
        static void primeNumber (ref int num, out bool prime)
        {
            prime=true;
            if (num < 2)
            {
                Console.WriteLine("Просте число не може бути меншим ніж число 2.", num);
            }
            if(num>=2 && num <4)
            {
                Console.WriteLine("Число {0} є простим", num);
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)// як виконати перевірку степенів простих чисел(25,49,121....)??
            {

                if (num % i == 0)
                {
                    Console.WriteLine("Число {0} є складним.", num);
                }
                else
                {
                    Console.WriteLine("Число {0} є простим.", num);
                }
                break;
            }
        }
        static void Remain(ref int num)
        {
            int[] divisor = { 2, 3, 5, 6, 9 };

            if(num % 2 != 0)
            {
                Console.WriteLine("Введене число {0} не ділиться на 2.", num);
            }
            else
            {
                Console.WriteLine("Введене число {0} ділиться на 2.", num);
            }
            if (num % 3 != 0)
            {
                Console.WriteLine("Введене число {0} не ділиться на 3.", num);
            }
            else
            {
                Console.WriteLine("Введене число {0} ділиться на 3.", num);
            }
            if (num % 5 != 0)
            {
                Console.WriteLine("Введене число {0} не ділиться на 5.", num);
            }
            else
            {
                Console.WriteLine("Введене число {0} ділиться на 5.", num);
            }
            if (num % 6 != 0)
            {
                Console.WriteLine("Введене число {0} не ділиться на 6.", num);
            }
            else
            {
                Console.WriteLine("Введене число {0} ділиться на 6.", num);
            }
            if (num % 9 != 0)
            {
                Console.WriteLine("Введене число {0} не ділиться на 9.", num);
            }
            else
            {
                Console.WriteLine("Введене число {0} ділиться на 9.", num);
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть число: ");
            int x = Int32.Parse(Console.ReadLine());
            bool prost=true;
            Number(ref x);
            primeNumber(ref x, out prost);
            Remain(ref x);

            Console.ReadKey();



        }
    }
}
