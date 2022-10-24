/*using System;

class Program 
{
    static void Main(string[] args) 
    {
      Console.WriteLine("Введите первое число");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      int y = Convert.ToInt32(Console.ReadLine());
      if (x == y*y)
      {Console.Write(y);
        Console.Write(" является квадратом числа ");
        Console.Write(x);}
      else
      {Console.Write(y);
        Console.Write(" не является квадратом числа ");
        Console.Write(x);}
    }
}*/


// 1. напишите програму, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
// 
// Console.WriteLine("Введите число 1: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2: ");
// int num2 = int.Parse(Console.ReadLine()!);

// if (Math.Pow(num2, 2) == num1)
// {
//     Console.WriteLine("Первое число является квадратом второго!");
// }
// else
// {
//     Console.WriteLine("не является квадратом!");
// }

// **1 задача** Напишите программу, которая на вход принимает число и выдаёт 
// его квадрат (число умноженное на само себя).
//  4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Ведите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int result = number * number;
// Console.WriteLine(result );

// второй вариант

// Console.WriteLine("Ведите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int result = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine(result);

// int sqr = Convert.ToInt32(Math.Pow(Num2, 2))-решение одной строкой

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите день недели: ");

// int NumberWeakDay = int.Parse(Console.ReadLine()!);

// switch (NumberWeakDay)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Субота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Такого дня недели нет");
//         break;
// }

// 3/Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.


Console.WriteLine("Введите число");

int n = int.Parse(Console.ReadLine()!);
int i = 0;
// int i = -n;
if (n > 0)
{
    i = n - n - n;
}
// else
// {
//     i = n;
//     n = n - n - n;
// }
while (i <= n)
{
    Console.Write($"{i}, ");
    i++;
}







