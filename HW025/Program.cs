System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

System.Console.Write("Число |");
System.Console.WriteLine("Куб числа");

while (i <= n)
{
    System.Console.Write($"{i}     | ");
    System.Console.WriteLine(Math.Pow(i, 3));
    i= i + 1;
}
