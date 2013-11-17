using System;
class CheckPointWithinCircleOutOfRectangle
{
	static void Main()
	{
		Console.Write("Input pointX value: ");
		double pointX = double.Parse(Console.ReadLine());

		Console.Write("Input pointY value: ");
		double pointY = double.Parse(Console.ReadLine());

		if ( (Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2) <= Math.Pow(3, 2)
			&& ( ( pointX < -1 || pointX > 5 ) || ( pointY < -1 || pointY > 1 ) ) ) )
		{
			Console.WriteLine("The point is within the circle and outside of the rectangle!");
		}
		else
		{
			Console.WriteLine("The point is outside the circle and/or inside the rectangle!");
		}
	}
}