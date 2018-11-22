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
            Console.WriteLine("Начнем же!");
            PrintStatus();

            InputB();

            DropCoin();

            Console.ReadKey();
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

        // ваша ставка
        private static int beth = 0;

        // ввод ставки
        static void InputB()
        {
            Console.WriteLine("Введите вашу ставку: орел - 0, все остальное - решка");
            string s = Console.ReadLine();

            // если строка равна 0, то ставка 0 - орел, иначе - решка
            if (s=="0")
            {
                beth = 0;
            }
            else
            {
                beth = 1;
            }

            Console.WriteLine($"Вы поставили на {beth}!");
        }

        // генератор случайных числел
        static Random r = new Random();

        // статус монеты (орел - решка)
        private static int Coin = 0;

        static void DropCoin()
        {
            Coin = r.Next(0, 2);
            Console.WriteLine($"Монета брошена и выпало...");
            Console.WriteLine($"Монета брошена и выпало...");
            Console.WriteLine($"Монета брошена и выпало... {Coin}");
        }
    }
}
