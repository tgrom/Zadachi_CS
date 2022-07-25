System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;



int CountDig(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        while (n != 0)
        {
            i++;
            n /= 10;
        }
        return i;
    }
}
System.Console.WriteLine(CountDig(n));
