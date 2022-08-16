//Выяснить являются ли три числа сторонами треугольника
//треугольник существует тогда и только тогда, когда сумма любых двух его сторон больше третьей стороны.


System.Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число");
double c = Convert.ToDouble(Console.ReadLine());
bool triangle = true;


Triangle(a, b, c);













void Triangle(double a, double b, double c)
{

    if (a + b > c && b + c > a && a + c > b)
    {
        System.Console.WriteLine(triangle);
    }
    else System.Console.WriteLine(!triangle);
}