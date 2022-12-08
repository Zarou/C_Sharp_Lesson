// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int arrayLength = 100;
int[] newArray = CreateArray(arrayLength);
int oddIndexElementSum = newArray[1];

for ( int i = 3; i < newArray.Length; i++)
{
    if (i%2 != 0)
    {
        oddIndexElementSum = oddIndexElementSum + newArray[i];
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {oddIndexElementSum}");

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 999);
    return array;
}