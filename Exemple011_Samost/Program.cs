// программу которая выводит 3-х значное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98
int rndNumer = new Random().Next(100, 1000);
Console.WriteLine($"Случайное 3-х значное число 100-999  => {rndNumer}");
int second = (rndNumer / 100) * 10;
int third = rndNumer % 10;
int sum = second + third;
Console.WriteLine(sum);