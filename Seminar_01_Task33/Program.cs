// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.WriteLine("Введите число для поиска в массиве:");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int[] targetArray = RandomArray();
foreach (int i in targetArray) Console.Write($"{i} |");
Console.WriteLine();
if (IsInArray(targetArray, inputNumber)) Console.WriteLine($"Числа {inputNumber} присутствует в массиве");
else Console.WriteLine($"Числа {inputNumber} НЕТ в массиве");


bool IsInArray(int[] userArray, int userNumber)
{
    bool inArray = false;
    // for (int i = 0;  i < userArray.Length; i++)
    foreach (int i in userArray)
    {
        if (i == userNumber) inArray = true;
    }
    return inArray;
}

int[] RandomArray()
{
    Console.WriteLine("Введите желаемое количество элементов массива (от 1 до 100):");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    do
    {
        if (arraySize < 1 || arraySize > 100)
        {
            Console.WriteLine($"Число {arraySize} выходит за пределы диапазона от 1 до 100. Повторите ввод:");
            arraySize = Convert.ToInt32(Console.ReadLine());
        }
    } while (arraySize < 1 || arraySize > 100);

    Console.WriteLine(arraySize);

    int[] randomArray = new int[arraySize];
    for (int i = 0; i < randomArray.Length; i++) randomArray[i] = new Random().Next(-99, 100);
    return randomArray;
}