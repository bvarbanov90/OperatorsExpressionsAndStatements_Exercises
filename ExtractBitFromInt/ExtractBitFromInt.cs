using System;
class ExtractBitFromInt
{
	static void Main(string[] args)
	{
		Console.Write("Input an integer number: ");
		int number = int.Parse(Console.ReadLine());

		Console.Write("Input an integer position bit check: ");
		int positionBit = int.Parse(Console.ReadLine());

		int mask = ~( 1 << positionBit );

		Console.WriteLine("Extracting the {0} bit from {1} integer results to the integer number {2}", positionBit, number, number & mask);
	}
}