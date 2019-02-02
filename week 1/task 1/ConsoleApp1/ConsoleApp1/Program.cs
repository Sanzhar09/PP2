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
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            s = Console.ReadLine().Split();
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                if (a[i] == 1)
                {
                    continue;
                }
                bool b = true;
                for(int j=2;j<a[i];j++)
                {
                    if(a[i]%j==0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.Write(a[i]);
                    Console.Write(" ");
                }
            }

            Console.ReadKey();
        }
    }
}
