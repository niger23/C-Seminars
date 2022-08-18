//Задача 1. Необходимо найти квадрат запрошенного числа.
/*
Console.Write("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());
int kvadrat = number*number;

Console.WriteLine ($"The quad of {number} is {kvadrat}");
*/

//Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Enter ur 1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ur 2st number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad = number2*number2;

if (number1 == quad)
{
    Console.WriteLine($"{number1} is quad {number2}");
}
else
{
    Console.WriteLine($"{number1} is not quad {number2}");
}
*/

//Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Enter ur number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int current = number1*(-1);
while (current <= number1)
{
    Console.Write(current + " ");
    current++;
}