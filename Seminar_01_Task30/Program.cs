// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int arrayLength = 8;
int[] binaryArray = FillArray(arrayLength);
OutputArray(binaryArray);

int[] FillArray(int length)
{
    int[] array = new int[length];
    for ( int i = 0; i < length; i++ ) array[i] = new Random().Next(0, 2);
    return array;
}

void OutputArray(int[] array)
{
    foreach (int d in array) Console.Write("{0} ", d);
}