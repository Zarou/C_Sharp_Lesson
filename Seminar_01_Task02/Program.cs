// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number to compare:");
int num01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number to compare:");
int num02 = Convert.ToInt32(Console.ReadLine());

if ( num01 > num02 )
{
    Console.WriteLine($"Out of two numbers you have entered, the MAX one is {num01} and the MIN one is {num02}");
}
else if ( num01 < num02 )
{
    Console.WriteLine($"Out of two numbers you have entered, the MAX one is {num02} and the MIN one is {num01}");
}
else
{
    Console.WriteLine($"Numbers you have entered are equal");
}