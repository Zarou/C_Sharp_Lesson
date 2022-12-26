// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int arrayM = new Random().Next(2, 9);
int arrayN = new Random().Next(2, 9);
double[,] randomArray = new double[arrayM, arrayN];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = new Random().NextDouble() * 100;
    }
}

Console.WriteLine("Случайным образом сгенерировнный массив вещественных чисел вышел следующим:");
Console.WriteLine("Размерность - {0} на {1}", arrayM, arrayN);
Console.WriteLine("Массив содержит следующие элементы:");
PrintArray(randomArray);

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}