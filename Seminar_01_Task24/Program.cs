// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.WriteLine("Введите число:");
int inputNum = Convert.ToInt32(Console.ReadLine());
// int resultSum = GetSum(inputNum);

Console.WriteLine($"Сумма чисел от 1 до {inputNum} будет - {GetSum(inputNum)}");

int GetSum(int number)
{
    int sum = 0;
    int i = 1;
    while (i <= number)
    {
        sum = sum + i;
        i++;
    }
    return sum;
}