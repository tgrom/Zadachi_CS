﻿Console.WriteLine("Введите число, соответсующие дню недели");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 1 && a <= 7)
{
    if (a == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (a == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (a == 3)
    {
        Console.WriteLine("Среда");
    }
    if (a == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (a == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (a == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (a == 7)
    {
        Console.WriteLine("Воскресенте");
    }
}
else Console.WriteLine("Не соответсвует дню недели");