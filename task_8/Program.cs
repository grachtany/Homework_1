// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
int count=1;
while (count<=numberA)
        { int rezult = count%2;
           if (rezult==0) Console.Write($" {count} , ");
           else Console.Write($" ");
            
            count++;
        }