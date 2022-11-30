﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти.

int quarterNum = GetQuarterNum();

if (quarterNum == 1) Console.WriteLine($"В {quarterNum} четверти координаты могут принимать следующие значения:\nX - от 0 (не включительно) до (+) бесконечности\nY - от 0 (не включительно) до (+) бесконечности");
else if (quarterNum == 2) Console.WriteLine($"В {quarterNum} четверти координаты могут принимать следующие значения:\nX - от 0 (не включительно) до (-) бесконечности\nY - от 0 (не включительно) до (+) бесконечности");
else if (quarterNum == 3) Console.WriteLine($"В {quarterNum} четверти координаты могут принимать следующие значения:\nX - от 0 (не включительно) до (-) бесконечности\nY - от 0 (не включительно) до (-) бесконечности");
else if (quarterNum == 4) Console.WriteLine($"В {quarterNum} четверти координаты могут принимать следующие значения:\nX - от 0 (не включительно) до (+) бесконечности\nY - от 0 (не включительно) до (-) бесконечности");

int GetQuarterNum()
{
    Console.WriteLine("Введите номер четверти для определения возможных координат (1, 2, 3 или 4)");
    int input = Convert.ToInt32(Console.ReadLine());
    do
    {
        if (input < 1 || input > 4)
        {
        Console.WriteLine("Вы ввели недопустимое число! Введите число от 1 до 4:");
        input = Convert.ToInt32(Console.ReadLine());
        }
    } while (input < 1 || input > 4);
    return input;
}