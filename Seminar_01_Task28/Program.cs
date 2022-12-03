// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

Console.WriteLine("Введите число:");
int inputNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведением чисел от 1 до {inputNum} будет - {GetMult(inputNum)}");

int GetMult(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++) mult = mult * i;
    return mult;
}