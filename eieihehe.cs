using System;

namespace eieihehe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++)
            {
                int c = 1;
                for (int q = 0; q < n - a; q++)
                {
                    Console.Write("");
                }
                for (int x = 0; x <= a; x++)
                {
                    Console.Write(" {0:D}", c);
                    c = c * (a - x) / (x + 1);

                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
