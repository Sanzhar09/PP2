using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        public static void Palindrome(string s) //метод для проверки на палиндром
        {
            for (int i=0;i<s.Length;i++) // цикл чтобы пройтись по строке
            {
                if (s[i] != s[s.Length - 1 - i]) // проверка на палиндром, если симметричные символы не равны, то 
                {
                    Console.WriteLine("NO"); // вывод "нет"
                    return; // чтобы выйти из метода
                }
            }
            Console.WriteLine("Yes");// иначе выводим да
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\pp2\week 2\task 1\String.txt");// считываем текст файла
            Palindrome(text); // вызов метода
            Console.ReadKey(); // чтобы не закрывала консоль
        }
    }
}
