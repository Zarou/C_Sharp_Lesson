// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int numRows = 4;
int numCols = 4;
int[,] spiralArray = new int[numRows, numCols];

int row = 0;
int col = 0;
int directionHor = 1;
int directionVer = 0;
int dirChanges = 0;
int visits = numCols;

for (int i = 0; i < spiralArray.Length; i++)
{
    spiralArray[row, col] = i + 1;
    if (--visits == 0)
    {
        visits = numCols * (dirChanges % 2) + numRows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = directionHor;
        directionHor = -directionVer;
        directionVer = temp;
        dirChanges++;
    }

    col += directionHor;
    row += directionVer;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) Console.Write("0{0} ", array[i, j]);
            else Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

// spiralArray = FillSpiral(numRows, numCols);
PrintArray2D(spiralArray);