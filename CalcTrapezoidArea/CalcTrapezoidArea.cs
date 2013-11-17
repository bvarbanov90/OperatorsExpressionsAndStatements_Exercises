using System;
class CalcTrapezoidArea
{
	static void Main()
	{
		Console.Write("Input sideA value: ");
		double sideA = double.Parse(Console.ReadLine());

		Console.Write("Input sideB value: ");
		double sideB = double.Parse(Console.ReadLine());

		Console.Write("Input height value: ");
		double height = double.Parse(Console.ReadLine());

		Console.WriteLine("The area of the trapezoid is {0:F6}", height * ( (sideA + sideB) / 2 ));
	}
}