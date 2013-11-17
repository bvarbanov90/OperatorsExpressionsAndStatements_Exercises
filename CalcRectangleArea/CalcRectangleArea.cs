using System;
class CalcRectangleArea
{
	static void Main()
	{
		Console.Write("Input height of the rectangle: ");
		double height = double.Parse(Console.ReadLine());

		Console.Write("Input width of the rectangle: ");
		double width = double.Parse(Console.ReadLine());

		Console.WriteLine("The area of the rectangle is {0:F6}", height * width);
	}
}