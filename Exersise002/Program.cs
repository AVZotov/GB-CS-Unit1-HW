int numberA, numberB, numberC, max;


Console.Clear();
Console.WriteLine("Program to determine max from 3 numbers");
Console.Write("Enter first number: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
numberC = Convert.ToInt32(Console.ReadLine());
max = numberA;

if (numberB > max)
    max = numberB;
if  (numberC > max)
    max = numberC;

Console.WriteLine ($"max value: {max}");

