/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите число: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out int num))
{
    Console.WriteLine("Не является числом");
    return;
}

Console.Write($"Таблица кубов чисел от 1 до {str}: ");
for (int i = 1; i <= num; i++)
    Console.Write(Math.Pow(i, 3).ToString() + " ");