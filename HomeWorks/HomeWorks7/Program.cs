// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 2);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нимимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] array)
{
    Console.WriteLine("Найдём элемент в заданном массиве!");
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    // Тут получается не индекс, а просто строка/столбец, поэтому немного отлично)

    if (row > array.GetLength(0) || column > array.GetLength(1))
        Console.WriteLine($"Элемент [{row},{column}] в данном массиве отсутствует!");
    else Console.WriteLine($"Элемент [{row},{column}] данного массива равен: {array[row - 1, column - 1]}!");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindElement(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нимимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] Average(int[,] array)
{
    double[] aveSum = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        aveSum[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            aveSum[i] += array[j,i];
        }
        aveSum[i] = Math.Round(aveSum[i]/array.GetLength(0), 1);
    }
    return aveSum;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] result = Average(myArray);
Console.WriteLine("Среднее арифмитическое каждого столбца:");
ShowArray(result);
*/