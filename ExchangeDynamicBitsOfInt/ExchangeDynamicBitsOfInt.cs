using System;
class ExchangeDynamicBitsOfInt
{
	static void Main()
	{
		Console.Write("Input unsigned integer number: ");
		uint number = uint.Parse(Console.ReadLine());

		Console.Write("Input p(firstPosition): ");
		byte firstPosition = byte.Parse(Console.ReadLine());

		Console.Write("Input q(secondPosition): ");
		byte secondPosition = byte.Parse(Console.ReadLine());

		Console.Write("Input k(number of bits to be exchanged): ");
		byte numOfExchangeBits = byte.Parse(Console.ReadLine());

		uint maskFirstPosition = 0;
		for (int i = firstPosition + numOfExchangeBits - 1; i >= firstPosition; i--)
		{
			maskFirstPosition = maskFirstPosition | ((uint)1 << i);
		}
		Console.WriteLine("Mask of P: {0:X8}", maskFirstPosition);

		uint maskSecondPosition = 0;
		for (int i = secondPosition + numOfExchangeBits - 1; i >= secondPosition; i--)
		{
			maskSecondPosition = maskSecondPosition | ((uint)1 << i);
		}
		Console.WriteLine("Mask of Q: {0:X8}", maskSecondPosition);

		uint resultMask = ~(maskFirstPosition | maskSecondPosition);
		Console.WriteLine("Mask of results: {0:X8}", resultMask);

		uint bitsFirstPosition = number & maskFirstPosition;
		uint bitsSecondPosition = number & maskSecondPosition;

		uint resultNumber;
		if (firstPosition < secondPosition)
		{
			resultNumber = (number & resultMask) | (bitsFirstPosition << secondPosition | bitsSecondPosition >> secondPosition);
		}
		else
		{
			resultNumber = (number & resultMask) | (bitsFirstPosition >> firstPosition | bitsSecondPosition << firstPosition);
		}

		Console.WriteLine("The resulting number after exchanging bits is {0}", resultNumber);
	}
}