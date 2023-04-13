

using POOConcepts4;

Console.WriteLine("POOConcepts4");
Console.WriteLine("============");

try
{
	Console.WriteLine(new Date4(2024, 2, 29));
	Console.WriteLine(new Date4(2009, 9, 23));
	Console.WriteLine(new Date4(2008, 11, 30));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}