//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое число в диапазоне от 1 до 1000");
int num = Convert.ToInt32(Console.ReadLine());
int numOutput = -num;

if (num > 0 && num < 1001)
{
    while (numOutput <= num)
    {
        Console.Write($"{numOutput} | ");
        numOutput++;
    }
} else {
    Console.WriteLine($"Вы ввели число вне возможного диапазона!");
}