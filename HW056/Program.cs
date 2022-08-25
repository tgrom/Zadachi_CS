// 56.Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr;

arr = Create2DArray(4, 3);
Print(arr);
Other(arr);


int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(1, 15);
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
void Other(int[,] a)
{
    // В цикле меняем первую строку матрицы с последней
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int temp = a[0, j];
        a[0, j] = a[a.GetLength(0) - 1, j];
        a[a.GetLength(0) - 1, j] = temp;
    }
    Console.WriteLine("Матрица после замены строк:");
    // Выводим полученную матрицу
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],6}");
        }
        Console.WriteLine();
    }
}