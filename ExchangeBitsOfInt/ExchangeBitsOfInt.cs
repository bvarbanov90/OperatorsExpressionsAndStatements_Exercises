using System;
class ExchangeBitsOfInt
{
	static void Main()
	{
		Console.Write("Input unsigned integer number: ");
		uint number = uint.Parse(Console.ReadLine());

		uint bits_3_4_5 = number & 0x00000038;
		uint bits_24_25_26 = number & 0x07000000;
		uint resultsNumber = (number & 0xF8FFFFC7) | (bits_3_4_5 << 21 | bits_24_25_26 >> 21);

		Console.WriteLine("The resulting number after exchanging bits 3,4,5 with 24,25,26 is {0}", resultsNumber);
	}
}