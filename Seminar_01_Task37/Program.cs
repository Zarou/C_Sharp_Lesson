// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// МОЖНО, КОНЕЧНО, ЧЕРЕЗ МЕТОД ГЕНЕРИРОВАТЬ СЛУЧАЙНЫЙ МАСССИВ С ПРОВЕРКОЙ ЧЕТНОСТИ КОЛИЧЕСТВА ЭЛЕМЕНТОВ, НО ЭТО СУТИ НЕ МЕНЯЕТ

int[] newArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
int[] resultArray = new int[newArray.Length/2];

for (int i = 0; i < newArray.Length/2; i++) resultArray[i] = newArray[i] * newArray[newArray.Length - i - 1];
foreach (int i in resultArray) Console.Write($"{i}\t");