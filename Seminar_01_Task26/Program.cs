// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число");
int inputNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {inputNum} составляет - {CountDigits(inputNum)}");

int CountDigits(int number)
{
    int i = 1;
    while ( number > 9 )
    {
        number = number / 10;
        i++;
    }
    return i;
}