// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b - ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число c - ");
int numberC = int.Parse(Console.ReadLine());
if (numberA>numberB)
    {
    if (numberA>numberC) Console.WriteLine($"Максимальное из трех чисел равно {numberA}" );
    else
    Console.WriteLine($"Максимальное из двух чисел равно {numberC}" );}
else 
    {
    if (numberB>numberC) Console.WriteLine($"Максимальное из двух чисел равно {numberB}" );
    else
    Console.WriteLine($"Максимальное из двух чисел равно {numberC}" );
    }
