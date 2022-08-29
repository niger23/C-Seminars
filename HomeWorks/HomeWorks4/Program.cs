// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int MathPow (int num, int deg)
{
    int res = 1;
    for (int i = 0; i < deg; i++)
    {
        res *= num; 
    }
    return res;
}
Console.WriteLine("Давайте возведём число в любую степень!");
Console.Write("Введите число которое будем возводить в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {number} будет возводить в степень: ");

int degree = Convert.ToInt32(Console.ReadLine());
int result = MathPow(number, degree);

Console.WriteLine ($"Число {number} в степени {degree} равняется {result}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine("Давайте посчитаем все цифры вашего числа!");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumN = SumNum(num);
Console.Write(sumN);
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Давайте самостоятельно заполним массив данными!");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray (int [] array)
{
    Console.Write("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

Console.WriteLine("Какого размера необходимо создать массив?");
Console.Write("Введите размер: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(sizeArr);
ShowArray(array);
*/