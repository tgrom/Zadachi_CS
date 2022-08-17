System.Console.WriteLine("Введите число");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число");
double k2 = Convert.ToDouble(Console.ReadLine());


Crossroad();













void Crossroad()
{

    double x = ((b2 - b1) * 1.0) / ((k1 - k2) * 1.0);
    double y = k1 * x + b1;
    System.Console.WriteLine($"({x}; {y})");
}



