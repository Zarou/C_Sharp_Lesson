// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

object[,] originalArray = new object[6,2] {{"YES", "NO"}, {"BLACK", "WHITE"}, {true, false}, {0, 1}, {"GET", "GIVE"}, {0.7, 7.4}};
object[,] copiedArray = new object[originalArray.GetLength(0), originalArray.GetLength(1)];

for (int i = 0; i < originalArray.GetLength(0); i++)
{
    for (int j = 0; j < originalArray.GetLength(1); j++) copiedArray[i,j] = originalArray[i,j];
}

Console.Write("Исходный массив:\t");
for (int i =0; i < originalArray.GetLength(0); i++)
{
    for (int j = 0; j < originalArray.GetLength(1); j++)
    {
        Console.Write("{0}\t", originalArray[i,j]);
    }
}

Console.Write("\nКопия массива:\t\t");
for (int i = 0; i < copiedArray.GetLength(0); i++)
{
    for (int j = 0; j < copiedArray.GetLength(1); j++)
    {
        Console.Write("{0}\t", copiedArray[i, j]);
    }
}