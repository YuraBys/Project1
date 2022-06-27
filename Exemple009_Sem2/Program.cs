// // 9. Напишите программу которая выводит случайное число из отрезка [10, 99] и выводит наибольшую цифру числа
// 78 - > 8
// 12 - > 2
// 85 - > 8

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// if(firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
  
}
int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры одиннаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");
