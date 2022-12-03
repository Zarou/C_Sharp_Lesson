// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// Рещается модификацией программы из Задачи 22

Console.WriteLine("Введите целое число:");
int inputNum = Convert.ToInt32(Console.ReadLine());
int[,] numbersArray = SquareNumbers(inputNum);
OutputArray(numbersArray);

int[,] SquareNumbers(int number)
{
    int[,] numSquaredArray = new int[number, 3];
    int n = 1;
    for (int i = 0; i < number; i++)
    {
        numSquaredArray[i, 0] = n;
        numSquaredArray[i, 1] = n * n;
        numSquaredArray[i, 2] = n * n * n;
        n++;
    }
    return numSquaredArray;
}

void OutputArray(int[,] array)
{
    Console.WriteLine("Вычисляем вторые и третьи степени целых чисел от 1 до {0}:", array.GetLength(0));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("Квадрат числа\t{0} = {1}\n", array[i, 0], array[i, 1]);
        Console.Write("Куб числа\t{0} = {1}\n", array[i, 0], array[i, 2]);
    }
}