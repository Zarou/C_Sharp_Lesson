// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3. Если N = 3 -> 0 1 1. Если N = 7 -> 0 1 1 2 3 5 8

int userInput = GetUserInput();
int[] fiboNumbers = new int[userInput];

for (int i = 0; i < fiboNumbers.Length; i++)
{
    if (i == 0 || i == 1) fiboNumbers[i] = i;
    else fiboNumbers[i] = fiboNumbers[i - 2] + fiboNumbers[i - 1];
}

Console.WriteLine($"Первые {userInput} числа Фибоначи следующие:");
PrintArray(fiboNumbers);

int GetUserInput()
{
    Console.Write($"Введите требумое количество чисел Фибоначи: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintArray(int[] array)
{
    foreach (var i in array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}