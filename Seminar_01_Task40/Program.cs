// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите длины сторон треугольника:");
int a = GetUserInput();
int b = GetUserInput();
int c = GetUserInput();

if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Треугольник возможен");
else Console.WriteLine("Треугольник невозможен");

int GetUserInput()
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}