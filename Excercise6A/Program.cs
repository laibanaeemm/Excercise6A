Console.WriteLine("This program will ask you to enter a number, to which the program will tell you whether that number is positive, negative or zero.");

int num;

Console.Write("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("This number is zero");
}
else if (num > 0)
{
    Console.WriteLine("This number is positive");
}
else
{
    Console.WriteLine("This number is negative");
}
