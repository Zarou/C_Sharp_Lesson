// Напишите программу, которая приинимает на вход 2 числа A и B и возводит число A в целую степень B с помощью рекурсии

int GetUserInput()
{
    Console.Write("Введите число: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

double NumberPowered(int baseNum, int powerNum)
{
    if (baseNum == 0 || baseNum == 1) return baseNum;
    if (powerNum > 1) return baseNum * NumberPowered(baseNum, --powerNum);
    if (powerNum < 1) return 1 / baseNum * NumberPowered(baseNum, ++powerNum);
    return baseNum;
}

int baseNumber = GetUserInput();
int powerNumber = GetUserInput();
double resultNumber = NumberPowered(baseNumber, powerNumber);

Console.WriteLine("{0} в степени {1} равно {2}", baseNumber, powerNumber, resultNumber);