using System;

namespace EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            String cad = "";
            for (int i = 0; i <= 100; i = i + 1)
            {
                cad = cad + " " + i;
                sum = sum + i;
            }
            Console.WriteLine(cad);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}