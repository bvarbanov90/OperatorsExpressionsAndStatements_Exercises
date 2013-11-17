using System;
class ExchangeBitsOfInt
{
	static void Main()
	{
		Console.Write("Input unsigned integer number: ");
		uint number = uint.Parse(Console.ReadLine());

		uint bits3_4_5 = number & 0x00000038;
		uint bits23_24_25 = number & 0x03800000;
		uint resultsNumber = (number & 0xFC7FFFC7) | (bits3_4_5 << 20 | bits23_24_25 >> 20);

		Console.WriteLine("The resulting number after exchanging bits 3,4,5 with 23,24,25 is {0}", resultsNumber);
	}
}