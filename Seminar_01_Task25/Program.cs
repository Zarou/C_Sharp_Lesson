// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число для возведения в степень:");
int baseNumber = GetInputNum();
Console.WriteLine("Введите степень:");
int powerNumber = GetInputNum();

int numPowered = PowNumber(baseNumber, powerNumber);
Console.WriteLine("Число {0} в степени {1} равно {2}", baseNumber, powerNumber, numPowered);

int PowNumber(int a, int b)
{
    int pow = a;
    for (int i = 2; i <= b; i++)
    {
        pow = pow * a;
    }
    return pow;
}

int GetInputNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}