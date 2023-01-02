// 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] newArray = CreateRandomArray2D();

for (int i = 0; i < newArray.GetLength(0); i++)
{
    int[] rowSorted = new int[newArray.GetLength(1)];
    int[] rowOriginal = new int[newArray.GetLength(1)];
    for (int j = 0; j < newArray.GetLength(1); j++) rowOriginal[j] = newArray[i, j];
    rowSorted = SortArrayDecrease1D(rowOriginal);
    for (int j = 0; j < rowSorted.Length; j++) newArray[i, j] = rowSorted[j];
}

PrintArray2D(newArray);

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

int[] SortArrayDecrease1D(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[i])
            {
                int minElement = array[j];
                array[j] = array[i];
                array[i] = minElement;
            }
        }
    }
    return array;
}