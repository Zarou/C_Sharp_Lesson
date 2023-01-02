// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя

int[,] newArray = CreateRandomArray2D();
int[,] resultArray = new int[newArray.GetLength(1), newArray.GetLength(0)];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++) resultArray[j, i] = newArray[i, j];
}

Console.WriteLine("Исходный массив:");
PrintArray2D(newArray);
Console.WriteLine("Итоговый массив:");
PrintArray2D(resultArray);

int[,] CreateRandomArray2D()
{
    Console.Write("Введите количество строк для создания массива:");
    int arrayM = GetUserInput();
    Console.Write("Введите количество столбцов для создания массива:");
    int arrayN = GetUserInput();
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

int GetUserInput()
{
    Console.WriteLine();
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintArray2D(int[,] array)
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