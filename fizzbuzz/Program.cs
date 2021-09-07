using System;
using System.Text;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var sb = new StringBuilder("");

                if(i % 3 == 0)
                {
                    sb.Append("Fizz");
                }

                if (i % 5 == 0)
                {
                    sb.Append("Buzz");
                }

                Console.WriteLine(sb);
            }
            Console.ReadKey();
        }
    }
}
