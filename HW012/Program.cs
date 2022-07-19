Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int a = n / 10;
int b = n % 10;

if (a >= b)
{
    Console.WriteLine(a);
}
else Console.WriteLine(b);
