// 54. Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали



int[,] arr;

arr = Create2DArray(4, 4);
Print(arr);

System.Console.WriteLine(SumMain(arr));




int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(0, 10);
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

int SumMain(int[,] a)
{
    int sum = 0;
    for (int i = 0; i < a.GetLength(0); i++)
        sum = sum + a[i, i];
    return sum;


}


