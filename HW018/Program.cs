System.Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
bool c = true;

if (a == b*b || b == a*a)
{
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine(!c);
}