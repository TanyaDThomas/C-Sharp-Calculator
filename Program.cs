
using System.Numerics;

internal partial class Program
{
  private static void Main(string[] args)
  {
    bool quit = false;

    while (!quit)
    {
      Console.WriteLine("Choose the number of an operation:");
      Console.WriteLine("1. ADDITION");
      Console.WriteLine("2. SUBTRACTION");
      Console.WriteLine("3. MULTIPLICATION");
      Console.WriteLine("4. DIVISION");

      int num1, num2;
      double num3, num4;
      int operation = Convert.ToInt32(Console.ReadLine());

      while (operation < 1 || operation > 4)
      {
        Console.WriteLine("Not a valid option. Please choose the NUMBER of the operation.");
        operation = Convert.ToInt32(Console.ReadLine());
      }

      switch (operation)
      {
        case 1:
          Console.WriteLine("YOU CHOSE ADDITION");
          num1 = GetNum("Please enter a number to add to: ");
          num2 = GetNum("Please enter another number to add: ");
          int sum = Add(num1, num2);
          Console.WriteLine($"{num1} + {num2} = {sum}");
          break;
        case 2:
          num1 = GetNum("Please enter a number to subtract from: ");
          num2 = GetNum("Please enter another number to subtract: ");
          int difference = Subtract(num1, num2);
          Console.WriteLine($"{num1} - {num2} = {difference}");
          break;
        case 3:
          Console.WriteLine("YOU CHOSE MULTIPLICATION");
          num3 = GetDouble("Please enter a number multiply: ");
          num4 = GetDouble("Please enter a number to multiply: ");
          double product = Multiply(num3, num4);
          Console.WriteLine($"{num3} * {num4} = {product}");
          break;
        case 4:
          Console.WriteLine("YOU CHOSE DIVISION");
          num3 = GetDouble("Please enter a number to divide from: ");
          num4 = GetDouble("Please enter another number to divide: ");
          double quotient = Divide(num3, num4);
          Console.WriteLine($"{num3} / {num4} = {quotient}");
          break;

      }
      Console.WriteLine("Press ENTER to continue or type quit to exit.");
      string? input = Console.ReadLine();
      if (input?.ToLower() == "quit")
      {
        quit = true;
      }
    }

  }

  private static int GetNum(string prompt)
  {
    int num;
    Console.WriteLine(prompt);
    return num = Convert.ToInt32(Console.ReadLine());
  }

  private static double GetDouble(string prompt)
  {
    double num;
    Console.WriteLine(prompt);
    return num = Convert.ToDouble(Console.ReadLine());
  }



  private static int Add(int num1, int num2)
  {
    return num1 + num2;
  }
  private static int Subtract(int num1, int num2)
  {
    return num1 - num2;
  }

  private static double Multiply(double num3, double num4)
  {
    return num3 * num4;
  }

  private static double Divide(double num3, double num4)
  {
    while (num4 == 0)
    {
      Console.WriteLine("Cannot divide by zero. Please try again.");
      Console.WriteLine("Enter number: ");
      num3 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter other number: ");
      num4 = Convert.ToDouble(Console.ReadLine());
    }
    return num3 / num4;


  }
}