using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); // используется для того чтобы считывать текст
            string[] s = sr.ReadToEnd().Split(); // считываем текст
            StreamWriter sw = new StreamWriter("output.txt"); // для того чтобы записывать текст
            List<int> ans = new List<int>(); // создаем лист для праймов 
            for (int i = 0; i < s.Count(); i++) // проходимся по всем числам(строкам) 
            {
                int b; // переменная для хранения числа
                int pr = 0; // 0 если нет делители 
                b = int.Parse(s[i]); // переводим из строки в число 
                for (int j = 2; j <= (int)Math.Sqrt(b); j++) // цикл для проверки на прайм
                {
                    if (b % j == 0) // если есть делитель 
                    {
                        pr = 1; //то меняем значение переменной
                        break; // выходим из цикла
                    }

                }
                if (pr == 0 && b != 1) // если переменная 0(нет делителей) и наше число не равно 1
                {
                    ans.Add(b); // то записываем в лист
                }
            }




            for (int i = 0; i < ans.Count(); i++) // проходимся по всем праймам в листе 
            {
                sw.Write(ans[i] + " "); // записываем в файл
            }
            sw.Close(); //закрываем streamwriter
            sr.Close(); // закрываем stremreader
            Console.ReadKey();
        }
    }
}