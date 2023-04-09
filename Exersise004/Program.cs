Console.Clear();
Console.WriteLine("Program to print all even values from 1 to N");
Console.Write("Enter the value (N): ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int counter = 1;

while (counter <= userNumber)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter}, ");
    }

    counter ++;
}