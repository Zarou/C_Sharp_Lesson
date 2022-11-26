//Программма выводит случайное число из отрезка 10-99 (вкл) и показывает наибольшую цифру числа
int randomNum = new Random().Next(10, 100);
int firstDigit = Decimal.ToInt32(randomNum/10);
int lastDigit = randomNum%10;

if (firstDigit > lastDigit) Console.WriteLine($"Выпало число {randomNum}. Наибольшей цифрой в нем является {firstDigit}");
else if (lastDigit > firstDigit) Console.WriteLine($"Выпало число {randomNum}. Наибольшей цифрой в нем является {lastDigit}");
else Console.WriteLine($"Цифры в числе {randomNum} одинаковые");