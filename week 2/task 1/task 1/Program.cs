using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        public static void Palindrome(string s)
        {
            for (int i=0;i<s.Length;i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\pp2\week 2\task 1\String.txt");
            Palindrome(text);
            Console.ReadKey();
        }
    }
}
