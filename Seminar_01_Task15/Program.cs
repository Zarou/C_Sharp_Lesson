// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число от 1 до 7:");
        int inputNum = Convert.ToInt32(Console.ReadLine());
        string[] weekDays = new string[7] { "MON", "TUE", "WEN", "THU", "FRI", "SAT", "SUN" };
        string[] weekEnds = new string[2] { "SAT", "SUN" };

        do
        {
            if (inputNum < 1 || inputNum > 7)
            {
                Console.WriteLine("Вы ввели неверное число. Нужно ввести целое число от 1 до 7");
                Console.WriteLine("Введите число:");
                inputNum = Convert.ToInt32(Console.ReadLine());
            }
        }
        while (inputNum < 1 || inputNum > 7);

        string dayOfWeek = weekDays[(inputNum - 1)];

        if (weekEnds.Contains(weekDays[(inputNum - 1)]))
        {
            Console.WriteLine($"Вы ввели число {inputNum}, соответствующее дню недели {dayOfWeek}, который является выходным");
        }
        else
        {
            Console.WriteLine($"Вы ввели число {inputNum}, соответствующее дню недели {dayOfWeek}, который НЕ является выходным");
        }
    }
}