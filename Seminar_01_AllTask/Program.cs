//Объединенное решение для всех задач первого семинара
//На первом этапе выбирается задача, далее вводятся соответствующие задаче данные

Console.WriteLine("Выберите желаемую задачу, введя соответствующий номер:");
Console.WriteLine("1 - Программа проверки, является ли первое число квадратом второго (Задача 1)");
Console.WriteLine("2 - Программа определения большего числа из двух введенных (Задача 2)");
Console.WriteLine("3 - Программа определения названия дня недели по введенному числу (Задача 3)");
Console.WriteLine("4 - Программа определения большего числа из трех введенных (Задача 4)");
Console.WriteLine("5 - Программа для введенного числа N, выводит все целые числа от -N до N (Задача 5)");
Console.WriteLine("6 - Программа для введенного числа N определяет, является ли оно четным (Задача 6)");
Console.WriteLine("7 - Программа для введенного числа N, выводит последнюю цифру этого числа (Задача 7)");
Console.WriteLine("8 - Программа для введенного числа N, выводит все четные числа от 1 до N (Задача 8)");
int taskNumber = Convert.ToInt32(Console.ReadLine());

// if (taskNumber == 1 || taskNumber == 2)
// {
//     Console.WriteLine("Enter the first number: ");
//     int numInput01 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the second number: ");
//     int numInput02 = Convert.ToInt32(Console.ReadLine());

// }
// else if (taskNumber == 4)
// {
//     Console.WriteLine("Enter three numbers you want to compare. After entering each number, press ENTER");
//     int numInput01 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"First number - {numInput01}");
//     int numInput02 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Second number - {numInput02}");
//     int numInput03 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Third number - {numInput03}");
// }

switch (taskNumber)
{
    case 1:
        
        Console.WriteLine("Enter the first number: ");
        Input.Numbers numInput01 = new numInput01();
        Console.WriteLine("Enter the second number: ");
        Input.Numbers numInput02 = new numInput02();
        if ( numInput01 == numInput02 * numInput02 )
        {
            Console.WriteLine($"The number {numInput01} is {numInput02} squared");
        }
        else
        {
            Console.WriteLine($"The number {numInput01} is NOT {numInput02} squared");
        }
        break;

    case 2:

        Console.WriteLine("Определяем большее и меньшее число из двух");
        Console.WriteLine("Введите первое число: ");
        Numbers numInput01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        Numbers numInput02 = Convert.ToInt32(Console.ReadLine());

        if ( numInput01 > numInput02 )
        {
            Console.WriteLine($"Из введенных чисел, максимальное - {numInput01} и минимальное - {numInput02}");
        }
        else if ( numInput01 < numInput02 )
        {
            Console.WriteLine($"Из введенных чисел, максимальное - {numInput02} и минимальное - {numInput01}");
        }
        else
        {
            Console.WriteLine($"Вы ввели одинаковые числа");
        }
        break;

    case 3:

        // Console.WriteLine("Enter number in a range from 1 to 7");
        // int numberEntered = Convert.ToInt32(Console.ReadLine());

        // if (numberEntered > 0 && numberEntered < 8)
        // {
        //     switch (numberEntered)
        //     {
        //         case 1:
        //             Console.WriteLine($"The {numberEntered} day of week is MONDAY");
        //             break;
        //         case 2:
        //             Console.WriteLine($"The {numberEntered} day of week is TUESDAY");
        //             break;
        //         case 3:
        //             Console.WriteLine($"The {numberEntered} day of week is WENSDAY");
        //             break;
        //         case 4:
        //             Console.WriteLine($"The {numberEntered} day of week is THURSDAY");
        //             break;
        //         case 5:
        //             Console.WriteLine($"The {numberEntered} day of week is FRIDAY");
        //             break;
        //         case 6:
        //             Console.WriteLine($"The {numberEntered} day of week is SATURDAY");
        //             break;
        //         case 7:
        //             Console.WriteLine($"The {numberEntered} day of week is SUNDAY");
        //             break;
        //         default:
        //             Console.WriteLine($"Something went wrong");
        //             break;
        //     }
        // }
        // else
        // {
        //     Console.WriteLine($"The number you have entered ({numberEntered}) is inacceptable number! Enter the number from 1 to 7");
        // }
        // break;

    case 4:

        // int maxNum;

        // if (numInput01 >= numInput02)
        // {
        //     maxNum = num01;
        //     if (numInput03 > maxNum)
        //     {
        //         maxNum = numInput03;
        //     }
        // }
        // else
        // {
        //     maxNum = numInput02;
        //     if (numInput03 > maxNum)
        //     {
        //         maxNum = numInput03;
        //     }
        // }

        // Console.WriteLine($"The biggest number entered is {maxNum}");
        // break;

    case 5:

        // Console.WriteLine("Введите целое число в диапазоне от 1 до 100");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int numOutput = -num;

        // if (num > 0 && num < 101)
        // {
        //     while (numOutput <= num)
        //     {
        //         Console.Write($"{numOutput} | ");
        //         numOutput++;
        //     }
        // } else {
        //     Console.WriteLine($"Вы ввели число вне возможного диапазона!");
        // }
        // break;

    case 6:

        // Console.WriteLine("Введите число для определения четности:");
        // int num = Convert.ToInt32(Console.ReadLine());

        // if (num % 2 == 0)
        // {
        //     Console.WriteLine($"Число {num} - четное");
        // }
        // else
        // {
        //     Console.WriteLine($"Число {num} - НЕ четное");
        // }
        // break;

    case 7:

        // //Данное решение успешно работает с числами от -999999999999999 до 999999999999999
        // Console.WriteLine("Введите число произвольное целое число от -999999999999999 до 999999999999999 для определения последней цифры в этом числе");
        // double numInputDbl = Convert.ToDouble(Console.ReadLine());
        // double numOutputDbl = Math.Abs(numInputDbl)%10;
        // Console.WriteLine($"Последняя цифра во введенном числе - {numOutputDbl}");
        // break;

    case 8:

        // Console.WriteLine("Введите целое число в диапазоне от 1 до 1000");
        // int numInputInt = Convert.ToInt32(Console.ReadLine());

        // if (numInputInt >= 1 && numInputInt <= 1000)
        // {
        //     int numNext = 1;
        //     while (numNext <= numInputInt)
        //     {
        //         if (numNext%2 == 0)
        //         {
        //             Console.Write($"{numNext} | ");
        //             numNext++;
        //         }
        //         else
        //         {
        //             numNext++;
        //         }
        //     }
        // }
        // else
        // {
        //     Console.WriteLine($"Вы ввели число вне диапазона");
        // }
        // break;

    default:
    Console.WriteLine("Произошла ошибка!");
    break;
}

namespace Input
{
    class Numbers
    {
        public int numInput01;
        public int numInput02;
        public int numInput03;
        public int Number01()
        {
            Console.WriteLine($"Введите первое число:");
            numInput01 = 1; //Convert.ToInt32(Console.ReadLine());
        }
        public int Number02()
        {
            Console.WriteLine($"Введите второе число:");
            numInput02 = 2; //Convert.ToInt32(Console.ReadLine());
        }
        public int Number03()
        {
            Console.WriteLine($"Введите третье число:");
            numInput03 = 3; //Convert.ToInt32(Console.ReadLine());
        }

    }
    
}