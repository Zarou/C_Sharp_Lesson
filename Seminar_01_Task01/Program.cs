// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the number: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number to check if the first number squared is equal to: ");
int num02 = Convert.ToInt32(Console.ReadLine());

if ( num01 == num02 * num02 )
{
    Console.WriteLine($"The number {num01} is {num02} squared");
}
else
{
    Console.WriteLine($"The number {num01} is NOT {num02} squared");
}