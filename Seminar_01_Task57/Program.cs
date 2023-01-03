// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] newArray = CreateRandomArray2D();
List<int> uniqueElements = new List<int>();

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (CheckUnique(uniqueElements, newArray[i, j]))
        {
            uniqueElements.Add(newArray[i, j]);
        }
    }
}

int[,] freqVocabArray = new int[uniqueElements.Count, 2];
uniqueElements.Sort();
foreach (int element in uniqueElements)
{
    int vocabIndex = uniqueElements.IndexOf(element);
    int elementsCounter = 0;
    freqVocabArray[vocabIndex, 0] = element;
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++) if (newArray[i, j] == element) elementsCounter++;
    freqVocabArray[vocabIndex, 1] = elementsCounter;
}

// Вывод результатов
Console.WriteLine("Сгенерирован следующий массив:");
PrintArray2D(newArray);
Console.WriteLine();
Console.WriteLine("В массиве содержатся следующие уникальные элементы:");
foreach (int i in uniqueElements) Console.Write("{0} ", i);
Console.WriteLine();
Console.WriteLine("\nИз них:");
for (int i = 0; i < freqVocabArray.GetLength(0); i++)
    Console.WriteLine("Элемент {0} встречается {1} раз(а)", freqVocabArray[i, 0], freqVocabArray[i, 1]);

// PrintArray2D(freqVocabArray);

int[,] CreateRandomArray2D()
{
    int arrayM = new Random().Next(2, 9);
    int arrayN = new Random().Next(2, 9);
    int[,] randomArray = new int[arrayM, arrayN];

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(0, 9);
        }
    }
    return randomArray;
}

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

bool CheckUnique(List<int> selectedElements, int number)
{
    bool isUnique = true;
    foreach (int element in selectedElements)
    {
        if (number == element) isUnique = false;
    }
    return isUnique;
}