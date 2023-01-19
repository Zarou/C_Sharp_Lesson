// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int firstNumber = 0;
int lastNumber = 0;

do
{
    Console.Write("Введите начальное число ряда: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число ряда: ");
    lastNumber = Convert.ToInt32(Console.ReadLine());
    if (firstNumber > lastNumber) Console.WriteLine("ОШИБКА: Начальное число должно быть меньше или равно конечному!");
} while (firstNumber > lastNumber);

List<int> numbersList = new List<int>();
int nextNumber = firstNumber;
do
{
    numbersList.Add(nextNumber);
    nextNumber++;
} while (nextNumber <= lastNumber);

int sumElements = 0;
foreach (int i in numbersList)
{
    sumElements = sumElements + i;
}

Console.WriteLine("Сумма натуральных чисел ряда от {0} до {1} равна {2}", firstNumber, lastNumber, sumElements);

