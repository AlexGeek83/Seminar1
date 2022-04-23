// Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

//int i;
//int number;

//i = 0;
//number = 5;

//while(i < number);
//{
//if (i % 2 == 0)
//        System.Console.WriteLine(i);  
//i = i + 1;     
//}
int N2;

N2 = 5;

int num = 0;
System.Console.WriteLine($"Чётные числа из диапазона от 1 до {N2}:");
while (num < N2)
{
    num++;
    if (num % 2 == 0) System.Console.Write($"{num} ");
}
System.Console.WriteLine(); System.Console.WriteLine();
