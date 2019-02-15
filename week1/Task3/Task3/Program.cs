using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //создаю массив и одноввременнно конвертирую его  вдвоичный тип
            string[] arr = Console.ReadLine().Split();
            //заполнить массив избегая пробелов  
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            //заполнить массив каждую ячейка один за другим и преобразовать его 
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }
            //вывод в консоль

            Console.ReadKey();//закрываем консольное окно нажатием любой кнопки 
        }
    }
}
