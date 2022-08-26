// 34A Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] a;

Init(out a);
Print(a);
int count;
Even(a);















void Init(out int[] a, int Length = 5)
{
    a = new int[Length];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(100, 1000);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],6}");
}




void Even(int[] a)
{
    count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($" \nКоличество четных чисел = {count}");
}



