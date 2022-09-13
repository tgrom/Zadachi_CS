// С клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки 
using System.Linq;
string data = "текст";
int count = data.Split(".").First().Length;
Console.WriteLine(count);
