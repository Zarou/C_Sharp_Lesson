int[,] numArray = new int[4, 2] {{1,1}, {2,4}, {3,9}, {4,16}};
OutputArray(numArray);

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("Квадрат числа {0} = {1}\n", array[i, 0], array[i, 1]);
    }
}