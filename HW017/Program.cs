System.Console.WriteLine("Введите число от 0 до 7");
int a = Convert.ToInt32(Console.ReadLine());
bool b = true;
if (1 <= a && a <= 7) {

if (a == 6 || a == 7) 
{
    System.Console.WriteLine(b);
}
else System.Console.WriteLine(!b);
}
else System.Console.WriteLine("Введите правильное число");
