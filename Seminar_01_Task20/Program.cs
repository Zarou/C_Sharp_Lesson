// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

Console.WriteLine("Для определения длины отрезка, введите координаты двух точек в 2D пространстве");
int pointAcoordX = GetInputNumber('A', 'X');
int pointAcoordY = GetInputNumber('A', 'Y');
int pointBcoordX = GetInputNumber('B', 'X');
int pointBcoordY = GetInputNumber('B', 'Y');
double lineLength = CalcLineLength(pointAcoordX, pointAcoordY, pointBcoordX, pointBcoordY);

Console.WriteLine($"Длина отрезка A({pointAcoordX}, {pointAcoordY}) - B({pointBcoordX}, {pointBcoordY}) составляет:\n{lineLength}");

int GetInputNumber(char p, char c)
{
    Console.WriteLine($"Введите координату {c} точки {p}:");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

double CalcLineLength(int ax, int ay, int bx, int by)
{
    double lengthAB = Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)), 2);
    return lengthAB;
}