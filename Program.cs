using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_Eratosthenes
{
    class Program
    {
        public static void SieveEratosthenes(List<bool> numbers, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                if (i == 0)
                {
                    numbers.Add(false);
                    continue;
                }

                if (i == 1)
                {
                    numbers.Add(false);
                    continue;
                }

                numbers.Add(true);
            }

            for (int i = 2; i < size; ++i)
            {
                if (numbers[i] != false)
                {

                    for (int j = i * i; j < size; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }
        }

        public static void PrintList(List<bool> numbers)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] == true)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }

        static void Main(string[] args)
        {
            int size = 0;

            if (!int.TryParse(args[0], out size))
            {
                return;
            }

            var numbers = new List<bool>();

            SieveEratosthenes(numbers, size);

            PrintList(numbers);

            Console.ReadKey();
        }
    }
}
