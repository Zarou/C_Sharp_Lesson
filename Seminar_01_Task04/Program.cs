// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter three numbers you want to compare. After entering each number, press ENTER");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"First number - {num01}");
int num02 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Second number - {num02}");
int num03 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Third number - {num03}");
int maxNum;

if (num01 >= num02)
{
    maxNum = num01;
    if (num03 > maxNum)
    {
        maxNum = num03;
    }
}
else
{
    maxNum = num02;
    if (num03 > maxNum)
    {
        maxNum = num03;
    }
}

Console.WriteLine($"The biggest number entered is {maxNum}");