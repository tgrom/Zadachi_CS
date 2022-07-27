//Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N = 7;
int[] a = new int[N];
Random random = new Random();

int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(1, 20);

}

for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i],6}");

}
for (int i = 1; i < a.Length; i = i + 2)

    System.Console.Write($"\nЧисло с нечетным индексом: {a[i],4}");
for (int i = 1; i < a.Length; i = i + 2)
    sum += a[i];
System.Console.WriteLine($"\nСумма чисел нечетных индексов массива = {sum}");




