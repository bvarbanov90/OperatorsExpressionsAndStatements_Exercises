using System;
class IntBitPositionValueModify
{
	static void Main()
	{
		Console.Write("Input an integer number: ");
		int number = int.Parse(Console.ReadLine());

		Console.Write("Input an integer position bit to be modified: ");
		int positionBit = int.Parse(Console.ReadLine());

		Console.Write("Input a value for position bit(0 or 1): ");
		int valueBit = int.Parse(Console.ReadLine());
		Console.WriteLine(valueBit);

		int result;
		if (valueBit == 0)
		{
			result = number & ~(1 << positionBit);
		}
		else if(valueBit == 1)
		{
			result = number | (1 << positionBit);
		}
		else
		{
			Console.WriteLine("Invalid value inputted: {0}!", valueBit);
			return;
		}

		Console.WriteLine("Modified position {0} bit with value of {1} for input number {2} results to the number {3}", positionBit, valueBit, number, result);
	}
}