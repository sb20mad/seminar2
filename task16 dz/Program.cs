﻿// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1 ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{ Console.WriteLine("ДА"); }
else
{ Console.WriteLine("NET"); }
