System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());


Main();

void Main()
{
    string binary = Convert.ToString(a, 2);
    Console.WriteLine(binary);

}