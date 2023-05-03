using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 684; // число, для якого ми хочемо отримати розклад
            Console.WriteLine($"Розклад числа {n} на прості множники:");

            for (int i = 2; i <= n; i++)
            {
                int count = 0; // лічильник кількості входжень простого множника

                while (n % i == 0)
                {
                    count++;
                    n /= i;
                }

                if (count > 0)
                {
                    Console.WriteLine($"{i}^{count}");
                }
            }
        }
    }
 }
