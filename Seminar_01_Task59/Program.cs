// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] newArray = CreateRandomArray2D();
int[,] resultArray = new int[(newArray.GetLength(0) - 1), (newArray.GetLength(1) - 1)];
int minNumber = newArray[0,0];
int minNumberRow = 0;
int minNumberCol = 0;

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (newArray[i,j] < minNumber)
        {
            minNumber = newArray[i,j];
            minNumberRow = i;
            minNumberCol = j;
        }
    }
}

for (int i = 0; i < newArray.GetLength(0); i++)
{
    if (i != minNumberRow)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (j != minNumberCol)
            {
                int row = i;
                int col = j;
                if (i > minNumberRow) row--;
                if (j > minNumberCol) col--;
                resultArray[row,col] = newArray[i,j];
            }
        }
    }
}

PrintArray2D(newArray);
Console.WriteLine();
Console.WriteLine("Минимальное число в массиве - {0}.\nНаходится в строке {1} и столбце {2}", minNumber, (minNumberRow + 1), (minNumberCol + 1));
Console.WriteLine();
PrintArray2D(resultArray);

int[,] CreateRandomArray2D()
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