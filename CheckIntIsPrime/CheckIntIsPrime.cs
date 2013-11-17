using System;
class CheckIntIsPrime
{
	static void Main()
	{
		Console.Write("Input an integer number: ");
		int number = int.Parse(Console.ReadLine());
		bool isPrime = true;

		for ( int checkNum = 2; checkNum <= Math.Sqrt(number); checkNum++ )
		{
			if ( number % checkNum == 0 )
			{
				isPrime = false;
				Console.Write("The number is divisible by {0}, therefore ", checkNum);
				break;
			}
		}

		if ( isPrime )
		{
			Console.WriteLine("The integer number {0} is prime!", number);
		}
		else
		{
			Console.WriteLine("the integer number {0} is not prime!", number);
		}
	}
}