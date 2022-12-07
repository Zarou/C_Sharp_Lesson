// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

object[] newArray = CreateArray();

Console.Write($"Массив состоит из следующих объектов:\n");
foreach (object i in newArray) Console.Write($"{i}\t");

object[] CreateArray()
{
    object[] array = new object[8];
    
    Console.WriteLine($"Создаем массив из из 8 объектов произвольного типа");
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"\nВедите объект {(i + 1)}");
        array[i] = Console.ReadLine();
    }
    return array;
}