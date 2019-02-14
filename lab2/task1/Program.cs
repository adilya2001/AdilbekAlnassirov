using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace palindromecheck
{
    class Program
    {
        static void Main(string[] args)
        {

            string s2;

            string s = File.ReadAllText(@"C:\Users\Куралай\source\repos\lab2\task1\text1.txt.txt");
            char[] ch = s.ToCharArray();

            Array.Reverse(ch);
            s2 = new string(ch);

            bool b = s.Equals(s2, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}