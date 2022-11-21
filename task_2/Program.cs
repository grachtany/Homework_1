// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b - ");
int numberB = int.Parse(Console.ReadLine());
if (numberA>numberB) Console.WriteLine($"Максимальное из двух чисел равно {numberA}, Минимальное из двух чисел равно {numberB}" );
if (numberA<numberB) Console.WriteLine($"Максимальное из двух чисел равно {numberB}, Минимальное из двух чисел равно {numberA}");
    else Console.WriteLine("Заданные числа равны");