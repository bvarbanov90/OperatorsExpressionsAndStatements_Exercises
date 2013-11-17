using System;
class CheckPointWithinCircle
{
	static void Main()
	{
		Console.Write("Input pointX value: ");
		double pointX = double.Parse(Console.ReadLine());

		Console.Write("Input pointY value: ");
		double pointY = double.Parse(Console.ReadLine());

		if ( Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= Math.Pow(5, 2) )
		{
			Console.WriteLine("The point is within the circle!");
		}
		else
		{
			Console.WriteLine("The point is outside the circle!");
		}
	}
}