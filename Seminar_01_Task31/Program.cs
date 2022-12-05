// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20. 9,  1, 0,  2,  8, -3, -1, 

int[] numArray = new int[12];
int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < numArray.Length; i++) numArray[i] = new Random().Next(-9, 10);

foreach (int i in numArray)
{
    if (i < 0) sumNeg = sumNeg + i;
    else sumPos = sumPos + 1;
}

Console.WriteLine($"В массиве");
foreach (int i in numArray) Console.Write($"{i} ");
Console.WriteLine($"\nСумма положительных элементов - {sumPos}\nСумма отрицательных элементов - {sumNeg}");