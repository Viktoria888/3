using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"сотые: {num / 100}");
            Console.WriteLine($"десятки: {num / 10 % 10}");
            Console.WriteLine($"единицы: {num % 10}");
            Console.ReadKey();
        }
    }
}
