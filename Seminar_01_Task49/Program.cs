// Задайте двумерный массив, найдите элементы у которых оба индекса четные и замените эти элементы на их квадраты.

int arrayM = new Random().Next(2, 9);
int arrayN = new Random().Next(2, 9);
int[,] randomArray = new int[arrayM, arrayN];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = new Random().Next(0, 9);
    }
}

Console.WriteLine("Оригинальный массив размерности - {0} на {1} следующий:", arrayM, arrayN);
PrintArray(randomArray);

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    if (i%2 == 0)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            if (j%2 == 0) randomArray[i, j] = Convert.ToInt32(Math.Pow(randomArray[i, j], 2));
            else continue;
        }
    }
    else continue;
}

Console.WriteLine("Результирующий массив размерности - {0} на {1} следующий:", arrayM, arrayN);
PrintArray(randomArray);

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