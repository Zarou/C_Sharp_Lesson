// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)

int arrayM = new Random().Next(2, 9);
int arrayN = new Random().Next(2, 9);
int[,] randomArray = new int[arrayM, arrayN];

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = new Random().Next(10, 99);
    }
}

int mainDiagSum = 0;
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        if (j == i) mainDiagSum = mainDiagSum + randomArray[i, j];
        else continue;
    }
}

Console.Clear();
Console.WriteLine("Для случайным образом сгенерированного массива:");
PrintArray(randomArray);
Console.WriteLine("Размерности - {0} на {1}", arrayM, arrayN);
Console.WriteLine("Сумма элементов главной диагонали будет составлять: {0}", mainDiagSum);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
