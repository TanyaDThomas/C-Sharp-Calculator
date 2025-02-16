
using System.Numerics;
using System.Xml.Schema;

internal partial class Program
{
  private static void Main(string[] args)
  {
    bool quit = false;

    while (quit == false)
    {
      Console.WriteLine("Choose the number of an operation:");
      Console.WriteLine("1. ADDITION");
      Console.WriteLine("2. SUBTRACTION");
      Console.WriteLine("3. MULTIPLICATION");
      Console.WriteLine("4. DIVISION");

      int num1, num2;
      double num3, num4;
      int operation = int.Parse(Console.ReadLine());

      switch (operation)
      {
        case 1:
          Console.WriteLine("YOU CHOSE ADDITION");
          Console.WriteLine("Enter number: ");
          num1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Other number: ");
          num2 = int.Parse(Console.ReadLine());
          int sum = Add(num1, num2);
          Console.WriteLine($"{num1} + {num2} = {sum}");
          break;
        case 2:
          Console.WriteLine("YOU CHOSE SUBTRACTION");
          Console.WriteLine("Enter number: ");
          num1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter other number: ");
          num2 = int.Parse(Console.ReadLine());
          int difference = Subtract(num1, num2);
          Console.WriteLine($"{num1} + {num2} = {difference}");
          break;
        case 3:
          Console.WriteLine("YOU CHOSE MULTIPLICATION");

          Console.WriteLine("Enter number: ");
          num3 = double.Parse(Console.ReadLine());
          Console.WriteLine("Enter pther number: ");
          num4 = double.Parse(Console.ReadLine());
          double product = Multiply(num3, num4);
          Console.WriteLine($"{num3} + {num4} = {product}");
          break;
        case 4:
          Console.WriteLine("YOU CHOSE DIVISION");

          Console.WriteLine("Enter number: ");
          num3 = double.Parse(Console.ReadLine());
          Console.WriteLine("Enter other number: ");
          num4 = double.Parse(Console.ReadLine());
          double quotient = Divide(num3, num4);
          Console.WriteLine($"{num3} + {num4} = {quotient}");
          break;
        default:
          Console.WriteLine("That is not a valid option. Please type in the number of the operation.");
          break;
      }
      Console.WriteLine("Press ENTER to continue or type quit to exit.");
      string? input = Console.ReadLine();
      if (input == "quit")
      {
        quit = true;
      }
    }

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
    return num3 / num4;
  }
}