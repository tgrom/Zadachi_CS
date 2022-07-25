System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
int mult = 1;

int Multiplication(int n)
{
    while (i <= n)
    {
        mult = mult * i;
        i++;
    }
    return mult;
}

System.Console.WriteLine(Multiplication(n));



