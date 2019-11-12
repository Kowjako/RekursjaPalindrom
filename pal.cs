using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            int x = Palindrom("XYRYXA");
            Console.Write(x == 1 ? "YES" : "NO");
            Console.Read();
        }
        static int Palindrom(string s)
        {
            if (s.Length == 1) return 1;
            if (s[0] == s[s.Length - 1])
            {
                s = s.Remove(0, 1);
                s = s.Remove(s.Length - 1, 1);
                return Palindrom(s);
            }
            else return 0;
        }
    }
}

