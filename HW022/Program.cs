System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

/*int a1 = a / 10000;
int a2 = a / 1000 % 10;
int a3 = a % 100 /10;
int a4 = a % 10;

if (a1 == a4 && a2 == a3) {
    System.Console.WriteLine("Yes");
}


System.Console.Write(a1);
System.Console.Write(a4);
System.Console.Write(a2);
System.Console.Write(a3);
*/

System.Console.WriteLine(Chek_out(a));

bool Chek_out(int a)
{
    
    int a1 = a / 10000;
    int a2 = a / 1000 % 10;
    int a3 = a % 100 /10;
    int a4 = a % 10;
    return a1 == a4 && a2 == a3;
}

