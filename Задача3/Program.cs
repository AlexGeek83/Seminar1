//Напишите программу, которая на вход принимает одно число
//(N), а на выходе показывает все целые числа в промежутке от -N
//до N.

int number, i;

number = 0;

i = - number;
while (i <= number)
{
    if (i == number)
         Console.Write($"{i}.");

    else
         Console.Write($"{i}, ");
    i++;
}


