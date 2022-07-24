System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= n)
{
    System.Console.Write($"{i} ");
    System.Console.WriteLine(i * i);
    i= i + 1;
}
