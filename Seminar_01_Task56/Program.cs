// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] newArray = CreateRandomArray2D();
int[] rowsArray = new int[newArray.GetLength(0)];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < newArray.GetLength(1); j++) rowSum = rowSum + newArray[i, j];
    rowsArray[i] = rowSum;
}

int strNum = 0;
int minSum = rowsArray[0];
for (int i = 1; i < rowsArray.Length; i++) if (rowsArray[i] < minSum) minSum = rowsArray[i];
for (int i = 0; i < rowsArray.Length; i++) if (rowsArray[i] == minSum) strNum = i + 1;

Console.WriteLine("Исходный массив:");
PrintArray2D(newArray);
Console.WriteLine("Минимальная сумма элементов в строке №{0} - {1}", strNum, minSum);

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