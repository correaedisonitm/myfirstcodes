Console.WriteLine("Ingrese un numreo");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString!);
if (numberInt %  2 == 0)
{
    Console.WriteLine($"El número {numberInt} es par");
}
else
{
    Console.WriteLine(" El número es ompar");
}
