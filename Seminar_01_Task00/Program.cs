
// int[] array = new int[9] {1,2,3,41,5,6,0,8,9};

// int min = array[0];
// int max = array[0];
// for (int i = 1; i < (array.Length); i++)
// {
//     if (min > array[i]) min = array[i];
//     if (max < array[i]) max = array[i];
// }

// Console.WriteLine($"Минимальное число {min}\nМаксимальное число {max}");
//foreach (int i in randomArray) Console.WriteLine(randomArray[i] + "\t");

List<int> userNumbers = new List<int>();
List<int> userNumbersSelection = new List<int>();
int userNumber = 0;
bool userInputNull = false;

do
{
    GetUserInput(out userNumber, out userInputNull);
    if (!userInputNull)
    {
        userNumbers.Add(userNumber);
        if (userNumber > 0)
        {
            userNumbersSelection.Add(userNumber);
        }
    }
} while (!userInputNull);

foreach (int i in userNumbers) 

void GetUserInput(out int userNumber, out bool userInputNull)
{
    string userIn = Console.ReadLine();
    int userNum = Convert.ToInt32(userIn);
    bool userInNull = String.IsNullOrEmpty(userIn);
    if (userInNull) userInputNull = true;
    else userInputNull = false;
    userNumber = userNum;
}