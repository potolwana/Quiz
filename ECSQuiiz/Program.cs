using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSQuiiz
{
 public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 9 != 0)
                {
                    Console.WriteLine("POP");
                }
                else if (i % 9 == 0 && i % 7 != 0)
                {
                    Console.WriteLine("QUIZ");
                }
                else if (i % 7 == 0 && i % 9 == 0)
                {
                    Console.WriteLine("POPQUIZ");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }
            int n = 2;

            while (n > 1)
            {
               n++;
            }
        }
    }
}
