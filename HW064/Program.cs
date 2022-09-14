// 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

AllNumbers(m, n);

void AllNumbers(int m, int n)
{

    for (int i = m; i <= n; i++)
        System.Console.Write($"{i} ");

}

