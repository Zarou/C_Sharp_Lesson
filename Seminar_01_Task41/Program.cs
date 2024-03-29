﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

List<int> userInputNumbers = new List<int>();
List<int> userNumbersSelect = new List<int>();
bool userInputEnd = false;
int userNumber;
Console.Clear();
Console.WriteLine("Для определения чисел больше 0, начните ввод чисел\nНажмите ENTER для окончания ввода\n");
do
{
    GetUserInput(out userNumber, out userInputEnd);
    if (!userInputEnd) userInputNumbers.Add(userNumber);
} while (!userInputEnd);
foreach (int i in userInputNumbers) if (i > 0) userNumbersSelect.Add(i);

Console.WriteLine($"Вы ввели {userInputNumbers.Count} чисел из которых {userNumbersSelect.Count} больше ноля\n");

void GetUserInput(out int userNumber, out bool userInputEnd)
{
    string userInput = Console.ReadLine();
    bool userInputEnter = false;
    int userNum = 0;
    if (!String.IsNullOrEmpty(userInput)) userNum = Convert.ToInt32(userInput);
    else {userInputEnter = true;} // Надо придумать, как обходить неназначение переменной userNum значения
    userNumber = userNum;
    userInputEnd = userInputEnter;
}