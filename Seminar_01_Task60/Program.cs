// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] newArray = CreateRandomArray3D();

Console.WriteLine("Массив имеет размерность [{0}, {1}, {2}]", newArray.GetLength(0), newArray.GetLength(1), newArray.GetLength(2));
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        for (int k = 0; k < newArray.GetLength(2); k++)
        {
            Console.WriteLine("По индексу [{0}, {1}, {2}] находится элемент {3}", i, j, k, newArray[i,j,k]);
        }
    }
}

int[,,] CreateRandomArray3D()
{
    int arrayM = new Random().Next(2, 9);
    int arrayN = new Random().Next(2, 9);
    int arrayP = new Random().Next(2, 9);

    int[,,] randomArray = new int[arrayM, arrayN, arrayP];

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                randomArray[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return randomArray;
}