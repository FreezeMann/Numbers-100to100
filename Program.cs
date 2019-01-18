using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100100_4_nie_810
{
    class Program
    {
        static void Main()
        {
            for (int i = -100; i <= 100; i++)
            {
                if ((i % 8 != 0) && (i % 10 != 0))
                {
                    if (i % 4 != 0) continue;
                    {
                        Console.WriteLine("Liczba podzielna przez 4 ale nie podzielne przez 8 i 10 " + i);

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
