// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа от M до N

Console.Write("Введите начальное число ряда: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число ряда: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
List<int> numbersList = new List<int>();

if (firstNumber > lastNumber)
{
    Console.WriteLine("ОШИБКА: Начальное число должно быть меньше или равно конечному!");
    return;
}

do
{
    numbersList.Add(firstNumber);
    firstNumber++;
} while (firstNumber <= lastNumber);

PrintList(numbersList);

void PrintList(List<int> list)
{
    Console.WriteLine("Натуральные числа от {0} до {1}:", list[0], list[list.Count - 1]);
    foreach (int i in list)
    {
        if (i != list[list.Count - 1]) Console.Write($"{i}, ");
        else Console.Write($"{i}\n");
    }
}