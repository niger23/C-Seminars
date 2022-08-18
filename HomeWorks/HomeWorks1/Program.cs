// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} это большее, а {number2} - меньшее число");
}
else
{
    Console.WriteLine($"{number2} это большее, а {number1} - меньшее число");
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine($"{max} это самое большое число");
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Проверим, чётное твоё число или нет.");
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} это чётное число.");
}
else
{
    Console.WriteLine($"{number} это нечётное число.");
}
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;  //Знаю, что можно присвоить сразу 2 и пройти напрямую через +2, без лишнего ответвления (else), просто так обыграл входные данные, "от 1":)

while (current <= number)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current);
        current += 2;
    }
    else
    {
        current++;
    }
}
*/