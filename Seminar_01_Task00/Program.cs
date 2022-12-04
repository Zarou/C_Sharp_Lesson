int number = 54;

int sum = 0;
int digitsCount = 1;
int n = number;
while (n > 9)
{
    n = n / 10;
    digitsCount++;
}
int[] numberArray = new int[digitsCount];
for (int i = (digitsCount - 1); i >= 0; i--)
{
    numberArray[i] = number % 10;
    number = decimal.ToInt32(number / 10);
}
for (int i = 0; i < numberArray.Length; i++) sum = sum + numberArray[i];


Console.WriteLine($"Сумма цифр равна {sum}");

