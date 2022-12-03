// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
// Очевидно решается копированием Задачи 20. Добавляем координату Z и - вуа-ля!

Console.WriteLine("Для определения длины отрезка, введите координаты двух точек в 2D пространстве");
int pointAcoordX = GetInputNumber('A', 'X');
int pointAcoordY = GetInputNumber('A', 'Y');
int pointAcoordZ = GetInputNumber('A', 'Z');
int pointBcoordX = GetInputNumber('B', 'X');
int pointBcoordY = GetInputNumber('B', 'Y');
int pointBcoordZ = GetInputNumber('B', 'Z');
double lineLength = CalcLineLength(pointAcoordX, pointAcoordY, pointAcoordZ, pointBcoordX, pointBcoordY, pointBcoordZ);

Console.WriteLine($"Длина отрезка A({pointAcoordX}, {pointAcoordY}, {pointAcoordZ}) - B({pointBcoordX}, {pointBcoordY}, {pointBcoordZ}) составляет:\n{lineLength}");

int GetInputNumber(char p, char c)
{
    Console.WriteLine($"Введите координату {c} точки {p}:");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

double CalcLineLength(int ax, int ay, int az,int bx, int by, int bz)
{
    double lengthAB = Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2);
    return lengthAB;
}