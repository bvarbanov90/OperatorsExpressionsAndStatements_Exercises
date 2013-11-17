using System;
class CheckBitPositionOfInt
{
	static void Main()
	{
		Console.Write("Input an integer number: ");
		int number = int.Parse(Console.ReadLine());

		Console.Write("Input an integer position bit check: ");
		int positionBit = int.Parse(Console.ReadLine());

		if ((number >> positionBit) % 2 != 0)
		{
			Console.WriteLine("The {0} bit of the input integer {1} is 1", positionBit, number);
		}
		else
		{
			Console.WriteLine("The {0} bit of the input integer {1} is 0", positionBit, number);
		}
	}
}