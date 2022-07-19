Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 10)
{
    Console.WriteLine("Необходимо ввести число больше 9");
}
else if (n >= 10 && n < 100)
{
    Console.WriteLine(n / 10);
}
else if (n >= 100 && n < 1000)
{
    int a = n / 100;
    int b = n % 10;
    Console.WriteLine($"{a}{b}");
}
else if (n >= 1000 && n < 10000)
{
    int f = n / 1000;
    int d = n % 100;
    //int e = n % 10;
    Console.WriteLine($"{f}{d}");
}
else Console.WriteLine("Необходимо ввести число меньше 10000");

