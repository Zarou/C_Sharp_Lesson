// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int[,] newArray = CreateRandomArray();
int[] bufferRow = new int[newArray.GetLength(1)];

Console.WriteLine("Оригинальный массив:");
PrintArrayRang2(newArray);

for (int i = 0; i < newArray.GetLength(1); i++) bufferRow[i] = newArray[0, i];
for (int i = 0; i < newArray.GetLength(1); i++) newArray[0, i] = newArray[(newArray.GetLength(0) - 1), i];
for (int i = 0; i < bufferRow.Length; i++) newArray[(newArray.GetLength(0) - 1), i] = bufferRow[i];

Console.WriteLine("Измененный массив:");
PrintArrayRang2(newArray);

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