// Написать программу замены элементов массива на противоположные

int N = 4;
int[] a = new int[N];
int[] b = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);

    b[i] = -1 * a[i];

}

for (int i = 0; i < a.Length; i++)

    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();



for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{b[i],4}");













