using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа:");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int с;
            с = a + b;
            Console.WriteLine("Сумма чисел равна:");
            Console.WriteLine(с);
            Console.ReadLine();
        }
    }
}
