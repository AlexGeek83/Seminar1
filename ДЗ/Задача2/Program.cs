﻿//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a = 2;
int b = 34;
int c = 77;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

System.Console.WriteLine($"Максимальное число {max}");

