//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число дня недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());
switch (numberDay)
 {
 case 1:
    Console.WriteLine("Понедельник");
     break;
case 2:
     Console.WriteLine("Вторник");
    break;
 case 3:
     Console.WriteLine("Среда");   
break;
case 4:
    Console.WriteLine("Четверг");   
break;
 case 5:
    Console.WriteLine("Пятница");   
 break;
case 6:
     Console.WriteLine("Суббота");   
 break;
 case 7:
     Console.WriteLine("Воскресенье");   
 break;
 }

if (numberDay == 6 || numberDay == 7)
    Console.WriteLine("Этот день выходной ДА");
else if (numberDay < 1 || numberDay > 7)
    Console.WriteLine("Это число не сответствует дню недели");
else Console.WriteLine("Этот день к сожелению не выходной");