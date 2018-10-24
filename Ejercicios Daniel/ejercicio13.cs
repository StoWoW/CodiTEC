// Enumerar numeros pares de 2 a 200
int i = 2;
while ((i >= 2) && (i <= 200))
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}