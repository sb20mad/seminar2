// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите число А делимое ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число В делитель ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС =  numberA % numberB;
if (numberС == 0)
{
Console.WriteLine("Кратно");
}
else
{
Console.WriteLine("Не кратно");
Console.WriteLine($"остаток {numberС}");
}