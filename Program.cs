﻿Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;
Console.WriteLine($"Результат: {result}");

if (num == result)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
