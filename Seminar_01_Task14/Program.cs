// Принимает на вход число и проверяет, кратно ли оно одновременно  7 и 23

Console.WriteLine("Введите целое число для определения его кратности числам 7 и 23:");
int inputNum = Convert.ToInt32(Console.ReadLine());

if (inputNum%7 == 0 && inputNum%23 == 0) {
    Console.WriteLine($"Число {inputNum} кратно числам 7 и 23");
} else {
    Console.WriteLine($"Число {inputNum} НЕ ЯВЛЯЕТСЯ кратным одновременно числам 7 и 23");
}