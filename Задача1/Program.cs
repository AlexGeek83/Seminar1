//Напишите программу, которая на вход принимает два числа и
//проверяет, является ли первое число квадратом второго.

int numberA, numberВ;
numberA = 5;
numberВ = 26;

numberA = numberA * numberA;

if (numberA == numberВ)
{
    Console.WriteLine($"Да, число Является квадратом числа" );
}
if (numberA != numberВ)
{
    Console.WriteLine("Нет, число НЕ  Является квадратом числа");
}