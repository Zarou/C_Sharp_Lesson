// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int arrayLength = 123;
int[] newArray = CreateArray(arrayLength);
int[] inRangeArray = new int[arrayLength];
int inRangeCount = 0;
int inRangeIndex = 0;

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] >= 10 && newArray[i] <= 99)
    {
        inRangeCount++;
        inRangeArray[inRangeIndex] = newArray[i];
        inRangeIndex++;
    }
}

Console.WriteLine($"В массиве:\n");
foreach (int i in newArray) Console.Write($"{i}\t");
Console.WriteLine($"\n\nнайдено {inRangeCount} элементов, лежащих в диапазоне от 10 до 99");

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(0, 999);
    return array;
}