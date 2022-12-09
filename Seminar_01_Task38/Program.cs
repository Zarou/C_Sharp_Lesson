// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double minNum;
double maxNum;
double[] numArray = CreateArray(10);
FindMinMax(numArray, out minNum, out maxNum);

Console.WriteLine($"|\n| В массиве:\n|");
foreach (double i in numArray) Console.Write($"|{i,6:F2}\t");
Console.WriteLine($"|\n|\n| Минимальное число {minNum,6:F2}, максиимальное число {maxNum,6:F2}\n|");

void FindMinMax(double[] array, out double minNum, out double maxNum)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < (array.Length); i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    minNum = min;
    maxNum = max;
}

double[] CreateArray(int length)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = rand.NextDouble() * 100;
    return array;
}