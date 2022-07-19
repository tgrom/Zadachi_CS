Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

/*if (n < 100)
{
    Console.WriteLine("Нет третьей цифры у данного числа");
}
else if (n >= 100 && n < 1000)
{
    Console.WriteLine(n % 10);
}
else if (n >= 1000 && n < 10000)
{
    int a = n / 10;
    Console.WriteLine(a % 10);
}
else if (n >= 10000 && n < 100000)
{
    int a = n / 100;
    Console.WriteLine(a % 10);
}
else Console.WriteLine("Необходимо ввести число меньше 100000");
*/



Console.WriteLine(n.ToString()[2]);

