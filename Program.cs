using System;

class Program {
    static void Main(string[] args) {
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
}
