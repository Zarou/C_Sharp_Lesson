// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "Phill";
int age = 21;
int result;
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(age);
result = age / 10;

Console.WriteLine(name + " is " + result);
Console.WriteLine($"The number you've entered is {num}");

if (num > age)
{
    Console.WriteLine($"{num} > {age}");
}
else
{
    Console.WriteLine($"{num} is not less then {age}");
}