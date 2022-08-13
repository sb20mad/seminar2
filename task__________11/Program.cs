// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine($"наше случаное число {number} ");
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1>digit2)
{
    Console.Write(digit1);
}
else
{
    Console.Write(digit2);
}
Console.WriteLine(" - наибольшее число");


void Foo()
{
   Console.Write("Невозвратный"); 
}

int returnFoo()
{
    return 1;
}

