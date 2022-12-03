int number = 54;
int digitsCount = 1;
int i = number;
while (i > 9) 
{
    i = i / 10;
    digitsCount++;
}
Console.WriteLine(digitsCount);