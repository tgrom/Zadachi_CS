Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());

if (b % a == 0)
{
    Console.WriteLine("Число a кратно числу b");
}
else Console.WriteLine(a % b);
