using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // деньги на игру - поля класса
        private static int Player = 100;
        private static int Comp = 100;

        // печать статуса
        static void PrintStatus()
        {
            Console.WriteLine("Что у нас с финансами?");
            Console.WriteLine($"У вас - {Player} руб., у компьютера - {Comp} руб.");
        }
    }
}
