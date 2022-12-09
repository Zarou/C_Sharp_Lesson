
int[] array = new int[9] {1,2,3,41,5,6,0,8,9};

int min = array[0];
int max = array[0];
for (int i = 1; i < (array.Length); i++)
{
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
}

Console.WriteLine($"Минимальное число {min}\nМаксимальное число {max}");
//foreach (int i in randomArray) Console.WriteLine(randomArray[i] + "\t");

