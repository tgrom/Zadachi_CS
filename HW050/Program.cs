// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] arr;

arr = CreatArray(3, 3);
Print(arr);
Solve(arr);
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

void Solve(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] % 2 == 0)
                a[i, j] = -a[i, j];

        }
    }
}

