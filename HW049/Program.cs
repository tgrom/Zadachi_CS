// 48. Показать двумерный массив размером m×n заполненный целыми случайными числами

double[,] arr;

arr = CreatArray(3, 4);
Print(arr);


double[,] CreatArray(int n, int m)
{
    double[,] a = new double[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.NextDouble() * 100;// получем числа от 0 до 99 с дробной частью
    return a;
}




void Print(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6:F2} ");//F2 - 2 знака после запятой
        System.Console.WriteLine();
    }
}

