//В Указанном массиве вещественных чисел найдите разницу между 
//максимальным и минимальным элементом

int N = 4;
int[] a = new int[N];
Random random = new Random();
//int max = a.Max;
//min = a.Min;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(1, 10);

}

/*int min = int.MaxValue;
for (int i = 0; i < a.Length; i++)
{
    if (min > a[i])
    {
        min = a[i];
    }
}
*/
int min = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < min)
    {
        min = a[i];
    }
}


/*int max = int.MinValue;
for (int i = 0; i < a.Length; i++)
{
    if (max < a[i])
    {
        max = a[i];
    }
}
*/
int max = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max)
    {
        max = a[i];
    }
}



for (int i = 0; i < a.Length; i++)

    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");
//System.Console.WriteLine(min);









