

using ConceptsPOO_3._0;

Console.WriteLine("POO Concepts 3.0");
Console.WriteLine("================");

try
{
	Console.WriteLine(new Date3(2024, 2, 29));
	Console.WriteLine(new Date3(2009, 9, 23));
	Console.WriteLine(new Date3(2008, 11, 30));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}
