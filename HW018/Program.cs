System.Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine(Chek_out(a, b));

bool Chek_out(int a, int b)
{
    return a == b * b || b == a * a;
}