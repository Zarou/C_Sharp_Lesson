// Задайте двумерный массив размером m*n, заполненый случайными целыми числами

int arrayM = new Random().Next(2, 9);
int arrayN = new Random().Next(2, 9);
int[,] randomArray = new int[arrayM,arrayN];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i,j] = new Random().Next(10, 99);
    }
}

Console.WriteLine("Случайным образом сгенерировнный массив целых чисел вышел следующим:");
Console.WriteLine("Размерность - {0} на {1}", arrayM, arrayN);
Console.WriteLine("Массив содержит следующие элементы:");
PrintArray(randomArray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i,j]);
        }
        Console.WriteLine();
    }
}