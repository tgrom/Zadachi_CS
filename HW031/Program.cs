System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
//int cub = i * i * i;
//int cub;

//System.Console.Write("Число |");
//System.Console.WriteLine("Куб числа");



while (i <= n)
{
    int cub = i * i * i;
    if (cub % 2 == 0)

        System.Console.WriteLine(cub);

    i = i + 1;
}








/*int Even(int n)
{
    while (i <= n)
    {
        return cub;

        i = i + 1;
    }

}
System.Console.WriteLine(Even(n));
*/
