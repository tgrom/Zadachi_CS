﻿Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b || b == a * a)
{
    Console.WriteLine("Да");
}


else Console.WriteLine("Нет");
