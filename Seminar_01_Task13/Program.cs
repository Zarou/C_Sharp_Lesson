// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Для определения третьей цифры в числе,\nвведите целое число:");
int inputNum = Convert.ToInt32(Console.ReadLine());
int numberPositions = 1000;

if (inputNum > -100 && inputNum < 100) {
    Console.WriteLine("Во введенном числе третьей цифры нет");
} else {
    while (Math.Abs(inputNum)/numberPositions > 0) {
        numberPositions = numberPositions * 10;
    }
    int thirdDigit = Math.Abs((inputNum / (numberPositions / 1000))%10);
    Console.WriteLine($"Вы ввели число {inputNum}\nВ этом числе третья цифра - {thirdDigit}");
}