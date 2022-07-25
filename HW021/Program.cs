System.Console.WriteLine("Введите число от 1 до 4");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    {
        Console.WriteLine("Х > 0 и Y > 0");
    }
else if (a == 2)
        {Console.WriteLine("Х < 0 и Y > 0");}
else if (a == 3)
        {Console.WriteLine("Х < 0 и Y < 0");}
else if (a == 4)
        {Console.WriteLine("Х > 0 и Y < 0");}
else
{
    System.Console.WriteLine("Ведите верное число");
}

