//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N = 123;
int[] a = new int[N];
Random random = new Random();
int k = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(1, 1000);


    int j = 0;

    while (j < a.Length) j++;
    if (a[i] >= 10 && a[i] < 100)
    {
        k++;
    }


}



for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i],6}");

}
System.Console.WriteLine($"\nКоличество чисел из отрезка [10, 99] = {k}");



