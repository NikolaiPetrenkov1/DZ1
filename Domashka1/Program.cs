//Practica N1
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
            String ima_i_fam;
            Console.WriteLine("Введите ваши имя и фамилию:\n");
            ima_i_fam = Console.ReadLine();
            Console.WriteLine("Ваши имя и фамилия:");
            Console.WriteLine(ima_i_fam);
            Console.ReadKey(true);
        }
    }
}

