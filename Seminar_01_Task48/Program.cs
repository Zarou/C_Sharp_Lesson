// Задайте двумерный массив размером m*n, каждый элемент в массиве находится по формуле  Amn = m+n

int arrayM = new Random().Next(2, 9);
int arrayN = new Random().Next(2, 9);
int[,] mnArray = new int[arrayM, arrayN];

for (int i = 0; i < mnArray.GetLength(0); i++)
{
    for (int j = 0; j < mnArray.GetLength(1); j++)
    {
        mnArray[i, j] = i + j;
    }
}

Console.WriteLine("Массив случайным образом выбранной размерности - {0} на {1},", arrayM, arrayN);
Console.WriteLine("Содержит следующие элементы:");
PrintArray(mnArray);

void PrintArray(int[,] array)
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