using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4
{
    class Program
    {
        static int MyCounter(string x)
        {
            int count = 0;
            for(int i = 0; i < x.Length;i++)
            {
                if(x[i] == '*')
                {
                    count++;
                }
            }
            return count;
        }
        static string RepeatingSign(string x)
        {
            int n = MyCounter(x);
            string res = "";
            for (int i = 0; i <= n; i++)
            {
                return x + String.Concat(Enumerable.Repeat("*", n));
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок символiв");
            string input = Console.ReadLine();
            char sign = '*';
            Console.WriteLine("");
            Console.WriteLine("Номер першого входження  *  у рядок "+ input.IndexOf(sign));
            Console.WriteLine("");
            Console.WriteLine("Кiлькiсть усiх входжень * = " + MyCounter(input));
            Console.WriteLine("");
            Console.WriteLine("Додаємо до кiнця рядка * n разiв");
            Console.WriteLine(RepeatingSign(input));
            Console.ReadKey();

        }
    }
}
