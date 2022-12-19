// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2, x * (k1 - k2) = b2 - b1, x = (b2 - b1)/(k1 - k2)
Console.Clear();
Console.WriteLine("Для нахождения точки пересечения двух прямых,\nзаданных уравнениями:\ny = k1 * x + b1\ny = k2 * x + b2\nвам необходимо ввести значения b1, k1, b2, k2");
string[,] requestedNums = new string[4, 2] {{"b1", "0"},{"k1", "0"},{"b2", "0"},{"k2", "0"}};
double[] crossingPointCoordinates = new double[2];

for (int i = 0; i < requestedNums.GetLength(0); i++) // Получаем данные от пользователя, заполняем массив
{
    requestedNums[i,1] = GetUserInput(requestedNums[i,0]);
}

double xCoord;
double yCoord;
if (requestedNums[1,1] == requestedNums[3,1] && requestedNums[0,1] == requestedNums[2,1]) Console.WriteLine("Прямые совпадают");
else if (requestedNums[1,1] == requestedNums[3,1] && requestedNums[0,1] != requestedNums[2,1]) Console.WriteLine("Прямые параллельны");
else
{
    FindCrossingPoint(requestedNums[0,1], requestedNums[1,1], requestedNums[2,1], requestedNums[3,1], out xCoord, out yCoord);
    Console.WriteLine(value: $"\nЗаданные прямые пересекаются в точке с координатами:\nx = {xCoord}\ny = {yCoord}");
}

string GetUserInput(string numberName)
{
    Console.WriteLine($"Введите значение {numberName}: ");
    string userInput = Console.ReadLine();
    return userInput;
}

void FindCrossingPoint(string B1, string K1, string B2, string K2, out double xCoord, out double yCoord)
{
    double x = Math.Round((Convert.ToDouble(B2) - Convert.ToDouble(B1)) / (Convert.ToDouble(K1) - Convert.ToDouble(K2)), 2, MidpointRounding.AwayFromZero);
    double y = Math.Round((Convert.ToDouble(K2) * x + Convert.ToDouble(B2)), 2, MidpointRounding.AwayFromZero);
    xCoord = x;
    yCoord = y;
}