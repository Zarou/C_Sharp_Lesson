//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число для определения четности:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} - четное");
}
else
{
    Console.WriteLine($"Число {num} - НЕ четное");
}