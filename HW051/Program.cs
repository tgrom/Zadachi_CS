//Создать подпрограмму Create2DArray(m,n), 
//которая возвращает двумерный массив следующим правилом: 
//Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива

int[,] arr;

arr = Create2DArray(5, 5);
Print(arr);


int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = i + j;
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

