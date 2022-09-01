// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int NumberEven (int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) current++;
    }
    return current;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
int current = NumberEven(myArray);
Console.WriteLine($"В приведённом массиве колличество чётных чисел равно: {current}.");
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, MaxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumNoEven(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2) sum += array[i];
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нимимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumNoEven(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {result}.");
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
    return newArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size);
ShowArray(myArray);
double maxNum = FindMax(myArray);
double minNum = FindMin(myArray);
double result = maxNum - minNum;
Console.WriteLine($"Разница максимального ({maxNum}) и минимального ({minNum}) элементов равна: {result}.");
*/
