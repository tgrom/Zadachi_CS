System.Console.WriteLine("Введите число X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("I");;
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("II");;
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("III");;
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("IV");;
}