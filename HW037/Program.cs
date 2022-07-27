//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N = 5;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(100, 1000);

//int number = 5;
int even = 0;
int odd = 0;
int j = 0;
for (int i = 0; i < a.Length; i++)
{
    while (j < a.Length) j++;
    {
        if (a[i] % 2 == 0)
        {
            even++;
        }
        else odd++;
    }
}



for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i],6}");

}

System.Console.WriteLine($" \nКоличество четных чисел = {even}");
System.Console.WriteLine($"Количество нечетных чисел = {odd}");
