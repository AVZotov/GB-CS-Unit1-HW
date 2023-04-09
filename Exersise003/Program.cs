Console.WriteLine("Program to determine if number if even or odd");
Console.Write("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber % 2 == 0)
{
    Console.WriteLine($"{userNumber} is even");
}
else
{
    Console.WriteLine($"{userNumber} is odd");
}
