// Имплементация известной лотереи СПОРТЛОТО "5 из 36" и "6 из 49"
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int minGameNum = 1;
        int maxGameNum = 0;
        int numOfChoice = 0;

        Console.WriteLine("Выберите вариант игры:\n1 - для игры 5 из 36\n2 - для игры 6 из 49");
        int gameOption = UserInputNumber(); // Выбор варианта 1 - "5 из 36", 2 - "6 из 49"
        if (gameOption == 1)
        {
            maxGameNum = 36;
            numOfChoice = 5;
        }
        else if (gameOption == 2)
        {
            maxGameNum = 49;
            numOfChoice = 6;
        }
        else InputErrorMsg();

        Console.WriteLine($"Вы выбрали игру {numOfChoice} из {maxGameNum}");
        Console.WriteLine($"Для продолжения вам необходимо выбрать {numOfChoice} номеров из диапазона {minGameNum} - {maxGameNum}\nПрограммма выберет соответствующее количество номеров из того же диапазона\nВ случае совпадения части номеров, вы получите приз-сюрприз!");

        int[] gameArray = FillGameArray(minGameNum, maxGameNum);
        int[] userArray = FillUserArray(numOfChoice);

        // -CHECK---------------------------------------------------

        Console.WriteLine("Игровой массив");
        foreach (int i in gameArray) Console.Write($" {i} |");
        Console.WriteLine("\nПользовательский массив");
        foreach (int i in userArray) Console.Write($" {i} |");

        // ---------------------------------------------------------

        // Заполнение массива игровых номеров в зависимости от выбранного варианта игры
        int[] FillGameArray(int min, int max) 
        {
            int[] array = new int[max];
            int number = min;
            for (int i = 0; i < max; i++)
            {
                array[i] = number;
                number++;
            }
            return array;
        }

        // Заполнение массива чисел, выбранных пользователем
        int[] FillUserArray(int choiceNum)
        {
            int[] array = new int[choiceNum];
            for (int i = 0; i < choiceNum; i++) array[i] = UserInputNumber();
            return array;
        }

        // Ввод числа пользователем
        int UserInputNumber()
        {
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        // Вывод сообщения об ошибке ввода
        void InputErrorMsg()
        {
            Console.WriteLine("ОШИБКА! Введены неверные данные");
        }
    }
}