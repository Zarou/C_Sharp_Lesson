// Задайте значение N. Напишите программу которая выведет все натуральные числа в промежутке от 1 до N

Console.Write("Введите число: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
int firstNumber = 1;
List<int> numbersList = new List<int>();

for (int i = 0; i < lastNumber; i++)
{
    numbersList.Add(firstNumber);
    firstNumber++;
}
PrintList(numbersList);

void PrintList(List<int> list)
{
    Console.WriteLine("Натуральные числа от 1 до {0}:", list[list.Count - 1]);
    foreach (int i in list)
    {
        if (i != list.Count) Console.Write($"{i}, ");
        else Console.Write($"{i}\n");
    }
}