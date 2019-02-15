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
            int n = int.Parse(Console.ReadLine()); //  (переводим строку в интежер) считываем количество чисел 
            string[] s = new string[n]; // массив строк создаем 
            s = Console.ReadLine().Split(); // считываем числа в виде строк 
            int[] a = new int[n]; // создаем массив интов
            List<int> l = new List<int>(); // создаем лист для хранения праймов
            for(int i = 0; i < n; i++) // цикл для перевода строки в число и проверки на прайм
            {
                a[i] = int.Parse(s[i]); // перевод из строки в число 
                if (a[i] == 1) // если единица то не прайм
                {
                    continue;
                }
                bool b = true; // если тру, значит прайм, если ложь, то нет
                for(int j=2;j<a[i];j++) // цикл для проверки на прайм 
                {
                    if(a[i]%j==0)// если цисло делится нацело 
                    {
                        b = false; // то оно не прайм
                        break;
                    }
                }
                if (b==true ) // если прайм 
                {
                    l.Add(a[i]); // то добавляем прайм в лист
                }
            }

            Console.Write(l.Count + " "); // выводим размер листа, это и есть количество праймов
            foreach(var v in l) // пробегаемся по всем праймам в листе
            {
                Console.Write(v + " "); // и выводим их
            }

            Console.ReadKey(); 
        }
    }
}
