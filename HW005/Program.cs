Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine(a);
}
if (b > a && b > c)
{
    Console.WriteLine(b);
}
if (c > a && c > b)
{
    Console.WriteLine(c);
}
if (a == b && b == c)
{
    Console.WriteLine("Числа равны");
}
