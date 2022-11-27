// Программа принимает 2 числа на вход и выводит является ли  второе число кратным первому.
// Если нет, программа выводит остаток от деления

Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum % secondNum == 0) {
    Console.WriteLine($"Второе число ({secondNum}) ЯВЛЯЕТСЯ кратным первому ({firstNum})");
}
else {
    Console.WriteLine($"Второе число ({secondNum}) НЕ ЯВЛЯЕТСЯ кратным первому ({firstNum}). Остаток - {firstNum % secondNum}");
}