// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"наше случаное число {number} ");
int digit2 = number % 10;
int digit1 = number / 100;
Console.WriteLine($"Первое число {digit1}");
Console.WriteLine($"Последнее число {digit2}");
Console.WriteLine($"Оба два числа {digit1} {digit2}");
