// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int number)
{
    int twoNum = number % 100;
    int oneNum = twoNum / 10;
    return oneNum;
}
int num = 0;
while ( num < 100 || num > 999)
{
    Console.Write("Введите число от 100 до 999: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int result = SecondNumber(num);
Console.WriteLine($"Вторая цифра числа: {num} является {result}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirdNumber(int number)
{
    if(number > 99)
    {
        int len = number.ToString().Length;
        int stepen1 = Convert.ToInt32(Math.Pow(10, len - 2));
        int stepen2 = Convert.ToInt32(Math.Pow(10, len - 3));
        int corNum = number % stepen1;
        int oneNum = corNum / stepen2;
        Console.WriteLine($"Третья цифра числа: {number} является {oneNum}.");
    }
    else
    {
        Console.WriteLine($"У числа: {number} третья цифра отсутствует.");
    }

}

Console.WriteLine("Давайте найдём третью цифру вашего числа!");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Days(int number)
{
    if(number <= 5)
    {
        Console.WriteLine($"День недели с порядковым номером {number} - будний.");
    }
    else
    {
        Console.WriteLine($"День недели с порядковым номером {number} - выходной.");
    }
}
int num = 0;
while ( num < 1 || num > 7)
{
Console.WriteLine("Введите число от 1 до 7.");
Console.WriteLine("Где 1 - Понедельник, а 7 - воскресенье.");
num = Convert.ToInt32(Console.ReadLine());
}
Days(num);
*/