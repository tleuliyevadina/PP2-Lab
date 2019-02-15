using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty; //представляет пустую строку. Это поле доступно только для чтения
            Console.WriteLine("Enter");
            s = Console.ReadLine();
            //заполнить строку
            char[] temp = s.ToCharArray();//массив символа
            Array.Reverse(temp); //инвертирует 
            string b = new string(temp); //присваиваем
            // конвертируем его в массив и возвращяем 

            if (s.Equals(b))//сравниваем его в обратную версию 
            {
                Console.WriteLine("POLINDROME");
            }
            else
            {
                Console.WriteLine("NOT POLINDROME");
            }
            Console.ReadKey();
        }
    }
}
