using System;
class Program
{
	static void Main()
	{
		Console.Write("Write an integer number: ");
		int number = int.Parse(Console.ReadLine());
		if ((number % 5 == 0) && (number % 7 == 0))
		{
			Console.WriteLine("{0} is dividable by 5 and 7 without a remainder", number);
		}
		else
		{
			Console.WriteLine("{0} is NOT dividable by 5 and 7 without a remainder", number);
		}
	}
}