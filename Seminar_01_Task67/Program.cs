// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

int userNumber = GetUserInput();
List<int> listOfDigits = ConvertNumberToList(userNumber);
int sumOfDigits = 0;

foreach (int i in listOfDigits) sumOfDigits = sumOfDigits + i;

Console.WriteLine("Сумма цифр числа {0} составляет {1}", userNumber, sumOfDigits);

List<int> ConvertNumberToList(int number)
{
    List<int> list = new List<int>();
    while (number >= 10)
    {
        int lastDigit = number%10;
        list.Insert(0,lastDigit);
        number = number / 10;
    }
    list.Insert(0, number);
    return list;
}

int GetUserInput()
{
    Console.Write("Введите число: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}