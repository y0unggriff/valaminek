using System;

namespace ahaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = int.Parse(Console.ReadLine());

            for (int i = 0; i <= j; i++)
            {
                Console.Write(i);

                if (i < j)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
