//Определить, присутствует ли в заданном массиве, некоторое число

int N = 5;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(1, 5);

int number = 5;
int j = 0;
while (j < a.Length && a[j] != number) j++;
if (j == a.Length)
{
    System.Console.WriteLine("NO");
}
else System.Console.WriteLine("Yes");

for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");
