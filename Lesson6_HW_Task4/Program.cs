using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HW_Task4
{
    class Program
    {
        static void Usd (ref double moneyValue, ref double course, out double converted)
        {
            converted = moneyValue * course;
        }
        static void Eur(ref double moneyValue, ref double course, out double converted)
        {
            converted = moneyValue * course;
        }
        static void Pln(ref double moneyValue, ref double course, out double converted)
        {
            converted = moneyValue * course;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть сумму, яку необхідно конвертувати: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Виберіть курс, за яким Ви бажаєте конвертувати, з нижче наведених валют:\n1 USD=27,8 UAH,\n1 EUR=32,5 UAH,\n1 PLN=7,33 UAH");
            Console.Write("Введіть курс: ");
            double course = Double.Parse(Console.ReadLine());
            double converted = 0;
            switch (course)
            {
                case 27.8:
                    {
                        Usd(ref x, ref course, out converted);
                        Console.WriteLine("Ви отримаєте {0} грн.", converted);
                        break;
                    }
                case 32.5:
                    {
                        Eur(ref x, ref course, out converted);
                        Console.WriteLine("Ви отримаєте {0} грн.", converted);
                        break;
                    }
                case 7.33:
                    {
                        Pln(ref x, ref course, out converted);
                        Console.WriteLine("Ви отримаєте {0} грн.", converted);
                        break;
                    }
            }


            Console.ReadKey();
        }
    }
}
