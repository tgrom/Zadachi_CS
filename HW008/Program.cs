/*int b = -20;
int a = 20;
//Console.WriteLine(a);
int i = b;
while (i <= a)
{
    Console.Write($"{i} ");

    i = i + 1;
}
*/
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int b = -n;
int i = b;
while (i <= n)
{
    Console.Write($"{i} ");

    i = i + 1;
}