using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HW_Task1
{
    class Program
    {
        static void AWG ( ref double firstValue, ref double secondValue, ref double thirdValue, out double res)
        {
             res = (firstValue + secondValue + thirdValue) / 3;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть перше число: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double y = Double.Parse(Console.ReadLine());
            Console.Write("Введіть третє число: ");
            double z = Double.Parse(Console.ReadLine());
            double res =0;
            AWG (ref x, ref y, ref z, out res);


            Console.WriteLine("Середнє значення введених чисел:{0}", res);
            Console.ReadKey();
        }
    }
}

