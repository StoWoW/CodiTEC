using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suponga que se tiene un conjunto de calificaciones de un grupo de 10 alumnos.
            //Realizar un algoritmo para calcular la calificación media y la calificación más baja de todo el grupo.
            int[] conteo = new int[] {12,13,17,11,10,9,18,20,4,6};
            int media = 0;
            int media1 = 0;
            int baja = conteo[0];
            int suma = 0;
            foreach (int i in conteo)
            {
                System.Console.Write(" {0} ", i);
            }
            for (var j = 1;j<conteo.Length;j++)
            {
                if (baja > conteo[j])
                {
                    baja = conteo[j];
                }
            }
            for (var i = 0;i<conteo.Length;i++)
            {
                suma = suma + conteo[i];
            }
            media1 = suma / 10;
            //Array.Sort(conteo);
            media = conteo[conteo.Length / 2-1];
            Console.WriteLine("\n" + baja);
            Console.WriteLine("\n" + media);
            Console.WriteLine("\n" + media1);
        }
    }
}
