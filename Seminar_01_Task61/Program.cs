// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int rowsNumber;
int fillNum = 1;
int blankSpace;

Console.Write("Введите количество строк: ");
rowsNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < rowsNumber; i++)
{
    for (blankSpace = 1; blankSpace <= rowsNumber - i; blankSpace++)
        Console.Write("  ");
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || i == 0)
            fillNum = 1;
        else
            fillNum = fillNum * (i - j + 1) / j;
        Console.Write("{0}   ", fillNum);
    }
    Console.Write("\n");
}