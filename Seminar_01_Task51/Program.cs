// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента, или же указание, что такого элемента нет.

int[,] newArray = CreateRandomArray();

Console.WriteLine("Был создан массив произвольной размерности. Введите номер строки и номер столбца для получения значения элемента");
Console.Write("Строка: ");
int arrayRow = GetUserInput();
Console.Write("Столбец: ");
int arrayCol = GetUserInput();

if ((arrayRow > 0 && (arrayRow - 1) < newArray.GetLength(0)))
{
    if ((arrayCol > 0 && (arrayCol - 1) < newArray.GetLength(1)))
    {
        Console.WriteLine("Элемент, находящийся на пересечении {0} строки и {1} столбца - {2}", arrayRow, arrayCol, newArray[(arrayRow - 1),(arrayCol - 1)]);
    }
    else Console.WriteLine("Номер столбца вне диапазона");
}
else Console.WriteLine("Номер строки вне диапазона");

Console.WriteLine("\nА массив был вот такой:");
PrintArrayRang2(newArray);

int GetUserInput()
{
    Console.WriteLine();
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateRandomArray()
{
    int arrayM = new Random().Next(2, 9);
    int arrayN = new Random().Next(2, 9);
    int[,] randomArray = new int[arrayM, arrayN];

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(10, 99);
        }
    }
    return randomArray;
}

void PrintArrayRang2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}