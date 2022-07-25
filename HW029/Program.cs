System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

//int i = 0;
//int k;
int sum = 0;

System.Console.WriteLine(SumDig(n));







int SumDig(int n)
{
    if (n < 10)
    {
        return n;
    }
    else
    {
        while (n != 0)
        {
            int k = n % 10;
            sum = sum + k;

            n /= 10;

        }
        return sum;
    }
}