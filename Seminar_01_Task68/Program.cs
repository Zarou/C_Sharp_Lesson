// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Для вычисления функции Аккермана Akkerman (m, n) введите последовательно значения m и n.");
int numberM = GetUserInput();
int numberN = GetUserInput();
int resultA = Akkerman(numberM, numberN);
Console.WriteLine("Результат функции Аккермана Akkerman(m, n) при заданных значениях M - {0} и N - {1} составляет: {2}", numberM, numberN, resultA);

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    else if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return Akkerman(m, n);
}

int GetUserInput()
{
    int inputNum;
    do
    {
    Console.Write("Введите неотрицательное число: ");
    inputNum = Convert.ToInt32(Console.ReadLine());
    if (inputNum < 0) Console.WriteLine("ОШИБКА!");
    return inputNum;
    } while (inputNum < 0);
}