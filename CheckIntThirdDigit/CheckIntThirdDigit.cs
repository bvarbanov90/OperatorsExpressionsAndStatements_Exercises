using System;
class CheckIntThirdDigit
{
	static void Main()
	{
		Console.Write("Input integer number: ");
		int number = int.Parse(Console.ReadLine()) % 1000;
		if ( number >= 700 && number < 800 )
		{
			Console.WriteLine("The third digit of the number is 7!");
		}
		else if ( number >= 100 )
		{
			Console.WriteLine("The third digit of the integer number is not 7!");
		}
		else
		{
			Console.WriteLine("There isn't a third digit of the integer number!");
		}
	}
}