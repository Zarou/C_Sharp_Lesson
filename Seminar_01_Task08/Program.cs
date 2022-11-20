//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число в диапазоне от 1 до 1000");
int numInputInt = Convert.ToInt32(Console.ReadLine());

if (numInputInt >= 1 && numInputInt <= 1000)
{
    int numNext = 1;
    while (numNext <= numInputInt)
    {
        if (numNext%2 == 0)
        {
            Console.Write($"{numNext} | ");
            numNext++;
        }
        else
        {
            numNext++;
        }
    }
}
else
{
    Console.WriteLine($"Вы ввели число вне диапазона");
}