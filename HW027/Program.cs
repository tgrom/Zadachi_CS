System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int pow = 1;
int i = 1;

while (i <= b)
{
    pow = pow * a;
    i = i + 1;
}
System.Console.WriteLine(pow);


