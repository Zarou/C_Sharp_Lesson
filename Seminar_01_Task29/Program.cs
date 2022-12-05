// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

object[] newArray = CreateArray();

Console.Write($"Массив состоит из следующих объектов:\n");
foreach (object i in newArray) Console.Write($"{i}\n");

object[] CreateArray()
{
    object[] array = new object[8];
    string type = "string";

    Console.WriteLine($"Создаем масси из из 8 объектов произвольного типа");
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"\nВедите объект {(i + 1)}");
        string newElement = Console.ReadLine();
        if (foreach (char c in newElement) c == 0 || c==1 || c==2 || c==3 || c==4 || c==5 || c==6 || c==7 || c==8 || c==9)
        {
            type = "int";
        }
    }
    return array;
}
