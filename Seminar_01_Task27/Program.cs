// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число для подсчета суммы цифр в нем:");
int inputNum = GetInputNum();

Console.WriteLine($"Сумма цифр в числе {inputNum} равна {GetSumOfDigits(inputNum)}");

int GetSumOfDigits(int number)
{
    int sum = 0;
    int digitsCount = 1;
    int n = number;
    while (n > 9)
    {
        n = n / 10;
        digitsCount++;
    }
    int[] numberArray = new int[digitsCount];
    int divider = 10;
    for (int i = (digitsCount - 1); i >= 0; i--)
    {
        numberArray[i] = number%divider;
        number = decimal.ToInt32(number/10);
    }
    for (int i = 0; i < numberArray.Length; i++) sum = sum + numberArray[i];
    return sum;
}

int GetInputNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}