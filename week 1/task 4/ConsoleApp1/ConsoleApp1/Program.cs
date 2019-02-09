using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // обьявляем размер массива и переводим его в интежер
            string [,] a = new string [n,n]; // создаем двумерный массив размером n*n
            for(int i=0;i<n;i++) // цикл для строк
            {
                for(int j=0;j<=i;j++) // цикл для столбцов
                {
                    a[i,j] = "[*]";
                    Console.Write(a[i,j]);// чтобы вывести звездочки
                    
                }
                Console.WriteLine(); // чтобы перейти на новую строку
            }
            Console.ReadKey(); // не закрылась чтобы.

        }
    }
}
