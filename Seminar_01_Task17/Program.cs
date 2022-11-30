// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X!=0 и Y!=0 и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите число, отличное от ноля, в качестве координаты X:");
int coordX = GetCoordinate();
Console.WriteLine("Введите число, отличное от ноля, в качестве координаты Y:");
int coordY = GetCoordinate();
int quarterNum = 0;

if (coordX > 0 && coordY > 0) quarterNum = 1;
else if (coordX < 0 && coordY > 0) quarterNum = 2;
else if (coordX < 0 && coordY < 0) quarterNum = 3;
else if (coordX > 0 && coordY < 0) quarterNum = 4;

Console.WriteLine($"Точка с координатами X = {coordX} и Y = {coordY} находится в четверти - {quarterNum}");

int GetCoordinate()
{
    int coordinate = Convert.ToInt32(Console.ReadLine());
    do
    {
        if (coordinate == 0)
        {
            Console.WriteLine("Вы ввели ноль в качестве координаты! Введите число, отличное от ноля:");
            coordinate = Convert.ToInt32(Console.ReadLine());
        }
    } while (coordinate == 0);
    return coordinate;
}