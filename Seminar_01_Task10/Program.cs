// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// В качестве дополнительного сервиса, производится проверка на трехзначность введенного числа
int inputNumber;
bool validNumber = true;

do
{
    if (!validNumber) Console.WriteLine("Вы ввели НЕ ТРЕХЗНАЧНОЕ число");
    Console.WriteLine(value: "Введите трехзначное число:");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    validNumber = CheckNumber(inputNumber);
}
while (!validNumber);

int midDigit = decimal.ToInt32(inputNumber / 10) % 10;

Console.WriteLine(value: "Вторая цифра введенного числа - " + midDigit);

bool CheckNumber(int i)
{
    if (i > 99 && i < 1000)
        return true;
    else
        return false;
}