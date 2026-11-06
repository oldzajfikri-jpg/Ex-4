using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;




            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 = sum1 + x;
                }
                else
                {
                    sum2 = sum2 + x;
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    int razlika = sum1 - sum2;
                    if (razlika < 0)
                    {
                        razlika = razlika * -1;
                        Console.WriteLine("No");
                    }
                }

            
            }

        }
    }
}
