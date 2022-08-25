// 48. Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] arr;

arr = CreatArray(3, 10);
Print(arr);


int[,] CreatArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(0, 100);
    return a;
}




void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}
