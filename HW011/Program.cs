Console.WriteLine("Введите число");
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
    int a = n / 10;
    int b = a % 10;
    Console.WriteLine(b);
}
else Console.WriteLine("Необходимо ввести число меньше 1000");
