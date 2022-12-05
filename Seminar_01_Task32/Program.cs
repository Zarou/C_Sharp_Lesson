// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] numArray = new int[12];
int[] numArrayInv = new int[numArray.Length];

for (int i = 0; i < numArray.Length; i++) numArray[i] = new Random().Next(-9, 10);
for (int i = 0; i < numArray.Length; i++) numArrayInv[i] = numArray[i] * -1;

Console.WriteLine($"Исходный массив:");
foreach (int i in numArray) Console.Write($"{i}\t");
Console.WriteLine($"\nИнвертированный массив:");
foreach (int i in numArrayInv) Console.Write($"{i}\t");