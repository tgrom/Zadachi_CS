System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
int sum = 0;
 


while (i <= n)
{
    sum = sum + i;
    i = i + 1;
}
System.Console.WriteLine(sum);
