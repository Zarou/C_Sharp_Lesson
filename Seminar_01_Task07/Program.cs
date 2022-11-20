﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//Данное решение успешно работает с числами от -999999999999999 до 999999999999999

Console.WriteLine("Введите число произвольное целое число от -999999999999999 до 999999999999999 для определения последней цифры в этом числе");
double numInputDbl = Convert.ToDouble(Console.ReadLine());
double numOutputDbl = Math.Abs(numInputDbl)%10;
Console.WriteLine($"Последняя цифра во введенном числе - {numOutputDbl}");