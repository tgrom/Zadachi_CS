
// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.



int[,] arr;

arr = Create2DArray(4, 3);
Print(arr);
SumStolb(arr);














int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(1, 5);
    return a;
}




void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}


void SumStolb(int[,] a)
{
    double[] sum = new double[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        sum[j] = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum[j] += a[i, j];
        }
        Console.WriteLine($"Среднее ариф =  {sum[j] / arr.GetLength(0)}");
    }
}