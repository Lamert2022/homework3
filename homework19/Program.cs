/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out int num))
{
    Console.WriteLine("Не является числом");
    return;
}

str = Math.Abs(num).ToString();
if (str.Length != 5)
{
    Console.WriteLine("Не является пятизначным числом");
    return;
}

char[] chArr = str.ToCharArray();
Array.Reverse(chArr);
string str2 = new string(chArr);

if (string.Equals(str, str2))
    Console.WriteLine($"Палиндром");
else
    Console.WriteLine($"Не палиндром");
