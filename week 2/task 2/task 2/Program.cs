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
            StreamReader sr = new StreamReader("input.txt");
            string[] s = sr.ReadToEnd().Split();
            StreamWriter sw = new StreamWriter("output.txt");
            List<int> ans = new List<int>();
            for (int i = 0; i < s.Count(); i++)
            {
                int b;
                int pr = 0;
                b = int.Parse(s[i]);
                for (int j = 2; j <= (int)Math.Sqrt(b); j++)
                {
                    if (b % j == 0)
                    {
                        pr = 1;
                        break;
                    }

                }
                if (pr == 0 && b != 1)
                {
                    ans.Add(b);
                }
            }




            for (int i = 0; i < ans.Count(); i++)
            {
                sw.Write(ans[i] + " ");
            }
            sw.Close();
            sr.Close();
        }
    }
}