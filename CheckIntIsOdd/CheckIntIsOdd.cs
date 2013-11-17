using System;
class CheckIntIsOdd
{
	static void Main()
	{
		Console.Write("Write an integer number: ");
		int number = int.Parse(Console.ReadLine());
		if (number % 2 == 0)
		{
			Console.WriteLine("{0} is an even number", number);
		}
		else
		{
			Console.WriteLine("{0} is an odd number", number);
		}
	}
}
