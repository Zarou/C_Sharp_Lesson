// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// ПРОБОВАЛ РАБОТАТЬ С НЕСКОЛЬКИМИ ВОЗВРАЩАЕМЫМИ МЕТОДОМ ЗНАЧЕНИЯМИ.
// НЕ УДАЛОСЬ РЕШИТЬ ПРОБЛЕМУ ИМЕН, ПРИШЛОСЬ ЧИТИТЬ С СТР 30, 31

int arrayLength = 0;
int count = 0;
int[] newArray = new int[arrayLength];
RandomArray(out newArray, out arrayLength);

Console.WriteLine($"Размер массива: {arrayLength}");
Console.WriteLine($"Элементы массива:");
foreach (int i in newArray) Console.Write($"{i} |");

foreach (int i in newArray)
{
    if (i%2 == 0)count++;
}
Console.WriteLine($"\nВ созданном массиве количество четных чисел - {count}");

void RandomArray(out int[] newArray, out int arrayLength)
{
    Console.WriteLine("Введите размер массива:");
    int lengthNum = Convert.ToInt32(Console.ReadLine());
    int[] randArray = new int[lengthNum];
    for (int i = 0; i < lengthNum; i++)
    {
        randArray[i] = new Random().Next(100, 1000);
    }
    newArray = randArray;
    arrayLength = lengthNum;
}