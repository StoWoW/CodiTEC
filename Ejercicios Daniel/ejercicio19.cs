int M = 0, N = 0;
Console.WriteLine("Ingrese el numero M:");
M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese el numero N:");
N = Convert.ToInt16(Console.ReadLine());
if (M < N)
{
    Console.WriteLine("Indice");
    for (int i = M; i <= N; i++)
    {
        Console.WriteLine(i);
    }
}
else { Console.WriteLine("M no es menor a N"); }