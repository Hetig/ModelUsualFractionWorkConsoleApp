using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelUsualFractionWorkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбранные дроби:");

            var fraction1 = new Fraction(4, 3);
            fraction1.Print();
            var fraction2 = new Fraction(1, 2);
            fraction2.Print();

            Console.WriteLine("Результаты операций дробей с дробными числами:");

            var result = fraction1.Sum(fraction2);
            result.Print();

            result = fraction1.Difference(fraction2);
            result.Print();

            result = fraction1.Multiplication(fraction2);
            result.Print();

            result = fraction1.Divide(fraction2);
            result.Print();

            Console.WriteLine();
            Console.WriteLine("Результаты операций дробей с целыми числами:");

            result = fraction1.Sum(1);
            result.Print();

            result = fraction1.Difference(1);
            result.Print();

            result = fraction1.Multiplication(2);
            result.Print();

            result = fraction1.Divide(2);
            result.Print();
        }
    }
}
