// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
int firstNumber = 1;
List<int> numbersList = new List<int>();

for (int i = 0; i < lastNumber; i++)
{
    numbersList.Add(firstNumber);
    firstNumber++;
}

PrintListReversed(numbersList);

void PrintListReversed(List<int> list)
{
    Console.WriteLine("Натуральные числа от {0} до 1:", list[list.Count - 1]);
    for (int i = list.Count - 1; i >= 0; i--)
    {
        if (i > 0) Console.Write("{0}, ", list[i]);
        else Console.Write("{0}\n", list[i]);
    }
}