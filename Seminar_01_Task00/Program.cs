
int[] uArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
int inputNumber = 7;

if (IsInArray(uArray, inputNumber)) Console.WriteLine("OK");
else Console.WriteLine("OK");

bool IsInArray(int[] userArray, int userNumber)
{
    bool inArray = false;
    foreach (int i in userArray)
    {
        if (userArray[i] == userNumber) inArray = true;
    }
    return inArray;
}


//foreach (int i in randomArray) Console.WriteLine(randomArray[i] + "\t");

