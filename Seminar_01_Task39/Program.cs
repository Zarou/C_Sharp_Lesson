// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] arrayDir = new int[10] {0,1,2,3,4,5,6,7,8,9};
int[] arrayRev = new int[arrayDir.Length];
int iRev = arrayDir.Length - 1;

for (int i = 0; i < arrayDir.Length; i++)
{
    arrayRev[iRev] = arrayDir[i];
    iRev--;
}
foreach (int i in arrayDir) Console.Write($" {i} |");
Console.WriteLine();
foreach(int i in arrayRev) Console.Write($" {i} |");
