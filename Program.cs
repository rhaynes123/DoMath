using System;

namespace DoMath
{
	class MainClass
	{
		
		//Method or Functioin For Addition
		public static double FindSum(double num1, double num2)
		{
			return (num1 + num2);
		}
		//Method or Function For Subtraction
		public static double FindDiff(double num1, double num2)
		{
			return (num1 - num2);
		}
		//Method or Function for Multiplication
		public static double FindProduct(double num1, double num2)
		{
			return (num1 * num2);
		}
		//Method or Function for Division
		public static double FindQuo(double num1, double num2)
		{
			return (num1 / num2);
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a number!");
			double num1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter another number!");
			double num2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Sum = " + FindSum(num1, num2)+"\nDifference= " + FindDiff(num1, num2)+ "\nProduct = " + FindProduct(num1, num2) + "\nQuotient = " + FindQuo(num1, num2) );


		}
	}
}
