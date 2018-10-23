using System;

namespace EJ17
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 1;
            for (nro = 1; nro < 101; nro++)
                Console.Write(nro + "=" + Math.Pow(nro, 2) + "\n\n");
            Console.ReadKey();
        }
    }
}