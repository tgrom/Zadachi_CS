System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());



Fibonacci();













void Fibonacci()
{

    int f1 = 0, f2 = 1, i;

    if (n < 1)
        return;
    Console.Write(f1 + " ");

    for (i = 1; i < n; i++)
    {
        Console.Write(f2 + " ");
        int next = f1 + f2;
        f1 = f2;
        f2 = next;
    }
}
