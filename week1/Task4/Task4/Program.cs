using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //ввела номер для массива
            int n = int.Parse(s);
            //для числа дала эквивалетный битовый номер
            for (int i = 0; i < n; i++)//обьявила цикл для массива 
            {
                for (int j = 0; j < i + 1; j++)//добавила второе измерение для массива 
                {
                    Console.Write("[*}");//заливка
                }
                Console.WriteLine();//output
            }
            //типичный код для создания и заполнения массива с помощью [*]

            Console.ReadKey();//закрыть консоль 
        }
    }
}
