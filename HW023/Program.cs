System.Console.WriteLine("Введите число X1");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число X2");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Distanse(x1, y1, x2, y2));

double Distanse(int x1, int y1, int x2, int y2) 
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}




