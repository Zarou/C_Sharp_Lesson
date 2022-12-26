// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] averageArray = new double[arrayN];
for (int i = 0; i < averageArray.Length; i++) averageArray[i] = 0;
for (int j = 0; j < randomArray.GetLength(1); j++)
{
    for (int i = 0; i < randomArray.GetLength(0); i++) averageArray[j] = averageArray[j] + randomArray[i, j];
    averageArray[j] = averageArray[j]/randomArray.GetLength(0);
}

Console.WriteLine("Массив случайным образом выбранной размерности - {0} на {1},", arrayM, arrayN);
Console.WriteLine("Содержит следующие элементы:");
PrintArrayRang2(randomArray);
Console.WriteLine("Средние арифметические элементов каждого столбца:");
PrintArrayRang1(averageArray);

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

void PrintArrayRang1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}:{1,6:F2}  ", i + 1, array[i]);
    }
}