// 36A Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. .

int[] a;
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int Length = Convert.ToInt32(Console.ReadLine());

Init(out a);
Print(a);
int sum;
SumOdd(a);















void Init(out int[] a)
{
    a = new int[Length];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],6}");
}




void SumOdd(int[] a)
{
    sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        sum = sum + a[i];
    }
    System.Console.WriteLine($" \nСумма элементов, стоящих на нечётных позициях = {sum}");
}



