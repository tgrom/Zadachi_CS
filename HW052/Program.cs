// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.



int[,] arr;

arr = Create2DArray(3, 4);
Print(arr);
System.Console.WriteLine();
IfEven(arr);
Print(arr);




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

void IfEven(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i = i + 2)

        for (int j = 0; j < a.GetLength(1); j = j + 2)
            a[i, j] = a[i, j] * a[i, j];

}


