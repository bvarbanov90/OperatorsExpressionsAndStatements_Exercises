using System;
class CheckBit3OfInteger
{
	static void Main()
	{
		Console.Write("Input an integer number: ");
		int number = int.Parse(Console.ReadLine());

		if ( (number &= 8) == 8 )
		{
			Console.WriteLine("The 3rd bit of the input integer is 1");
		}
		else
		{
			Console.WriteLine("The 3rd bit of the input integer is 0");
		}
	}
}