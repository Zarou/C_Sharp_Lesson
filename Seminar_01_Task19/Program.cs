// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int inputNum = GetInputNumber();
int numOfDigits = ((int)Math.Abs(inputNum)).ToString().Length;
int[] inputNumArray = new int[numOfDigits];
bool isPalindrom = false;

int inputNumRec = inputNum;
for ( int i = (numOfDigits - 1); i >= 0; i--)
{
    inputNumArray[i] = inputNumRec % 10;
    inputNumRec /= 10;
}

for (int i = 0; i < (inputNumArray.Length / 2); i++)
{
    if (inputNumArray[i] == inputNumArray[^(i + 1)]) isPalindrom = true;
}

if (isPalindrom) Console.WriteLine($"Число {inputNum} является палиндромом");
else Console.WriteLine($"Число {inputNum} НЕ является палиндромом");

int GetInputNumber()
{
    Console.WriteLine("Введите произвольное натуральное число:");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}