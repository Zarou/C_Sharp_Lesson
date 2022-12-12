// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите десятичное число для переводя его в двоичный формат: ");
int numDecimal = GetUserInput();
int numDivisor = 2;
List<int> numBinary = new List<int>();
if (numDecimal > 1)
{
    while (numDecimal >= numDivisor)
    {
        var numRemainder = numDecimal - (numDivisor * Convert.ToInt32(numDecimal / numDivisor));
        numDecimal = Convert.ToInt32(numDecimal / numDivisor);
        numBinary.Insert(0,numRemainder);
    }
    numBinary.Insert(0,1);
}
else numBinary.Add(numDecimal);

foreach (var i in numBinary) Console.Write(i);

int GetUserInput()
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}