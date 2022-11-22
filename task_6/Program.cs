// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
int rezult = numberA%2;
if (rezult==0) Console.WriteLine($"Число {numberA} - четное" );
    else
    Console.WriteLine($"Число {numberA} - нечетное" );
