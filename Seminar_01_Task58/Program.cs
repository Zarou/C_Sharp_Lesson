// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] matrixA = new int[2,2] {{2,5},{3,8}};
int[,] matrixB = new int[2,3] {{7,3,5},{2,4,9}};
int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];

if (matrixA.GetLength(1) != matrixB.GetLength(0)) Console.WriteLine("Умножение матриц невозможно!");
else
{
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
        }
    }
}
}

PrintArray2D(matrixC);

void PrintArray2D(int[,] array)
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