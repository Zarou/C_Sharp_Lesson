// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Enter number in a range from 1 to 7");
int numberEntered = Convert.ToInt32(Console.ReadLine());

if (numberEntered > 0 && numberEntered < 8)
{
    switch (numberEntered)
    {
        case 1:
            Console.WriteLine($"The {numberEntered} day of week is MONDAY");
            break;
        case 2:
            Console.WriteLine($"The {numberEntered} day of week is TUESDAY");
            break;
        case 3:
            Console.WriteLine($"The {numberEntered} day of week is WENSDAY");
            break;
        case 4:
            Console.WriteLine($"The {numberEntered} day of week is THURSDAY");
            break;
        case 5:
            Console.WriteLine($"The {numberEntered} day of week is FRIDAY");
            break;
        case 6:
            Console.WriteLine($"The {numberEntered} day of week is SATURDAY");
            break;
        case 7:
            Console.WriteLine($"The {numberEntered} day of week is SUNDAY");
            break;
        default:
            Console.WriteLine($"Something went wrong");
            break;
    }
}
else
{
    Console.WriteLine($"The number you have entered ({numberEntered}) is inacceptable number! Enter the number from 1 to 7");
}
