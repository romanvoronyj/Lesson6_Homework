using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HW_Task
{
    class Program
    {
        static bool prost = true;
        static int k = 2;
        static int n;

        static void Func(int k)
        {
            if (k < (n / 2))
                if (n % k == 0)
                    prost = false;
                else
                {
                    k++;
                    Func(k);
                }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число\n");
            n = int.Parse(Console.ReadLine());
            Func(k);

            if (prost) Console.WriteLine("Число простое");
            else Console.WriteLine("Число не простое");

            Console.ReadKey();
        }

    }
}
