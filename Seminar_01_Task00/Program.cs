string inputNumStr = Console.ReadLine();
char[] inputNumArray = new char[4];

for ( int i = 0; i < inputNumArray.Length; i++)
{
    // int i = 0;
    Console.Write($"{i} |");
    // Console.Write($"{c} | ");
    // inputNumArray[i] = c;
    // i++;
}



foreach (char element in inputNumArray)
{
    Console.Write($"{element} | ");
}