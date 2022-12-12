/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координаты A: ");
var str = Console.ReadLine() ?? "";
string[] strArr = str.Split(' ');

int[] crdnt0 = new int[strArr.Length];
for (int i = 0; i < strArr.Length; i++)
    crdnt0[i] = int.Parse(strArr[i]);

Console.Write("Введите координаты B: ");
str = Console.ReadLine() ?? "";
strArr = str.Split(' ');

int[] crdnt1 = new int[strArr.Length];
for (int i = 0; i < strArr.Length; i++)
    crdnt1[i] = int.Parse(strArr[i]);

Console.WriteLine(
    Math.Sqrt(Math.Pow((crdnt1[0] - crdnt0[0]), 2) + 
    Math.Pow((crdnt1[1] - crdnt0[1]), 2) + 
    Math.Pow((crdnt1[2] - crdnt0[2]), 2)).ToString());
