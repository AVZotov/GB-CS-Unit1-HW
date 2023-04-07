int numberA;
int numberB;

Console.Clear();
Console.WriteLine("Program to determine max from 2 numbers");
Console.Write("Enter first number: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
    Console.WriteLine($"max = {numberA}");
else if (numberB > numberA)
    Console.WriteLine($"max = {numberB}");
else
    Console.WriteLine("values are equal");

