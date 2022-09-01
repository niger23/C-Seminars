// Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и 
//  положительных элементов массива.

// int [] CreateRandomArray(int size, int minValue, int MaxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, MaxValue +1);
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int FindPositiveSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sum += array[i];
//     }
//     return sum;
// }

// int FindNegativeSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sum += array[i];
//     }
//     return sum;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нимимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);

// int positiveSum = FindPositiveSum(myArray);
// int negativeSum = FindNegativeSum(myArray);

// Console.WriteLine($"Сумма позитивных элементов: {positiveSum} \nСумма отрицательных элементов: {negativeSum}");


// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

// int [] CreateRandomArray(int size, int minValue, int MaxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, MaxValue +1);
//     }
//     return newArray;
// }
// void ShowArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] Replace(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нимимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);
// Replace(myArray);
// ShowArray(myArray);


// Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.

// int [] CreateRandomArray(int size, int minValue, int MaxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, MaxValue +1);
//     }
//     return newArray;
// }

// bool FindNumber(int[] array, int number)
// {
//     bool result = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number) 
//         {
//             result = true;
//             break;
//         }        
//     }

//     return result;
// }
// void ShowArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нимимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);

// Console.Write("Введите значение для поиска: ");
// int findNum = Convert.ToInt32(Console.ReadLine());

// Console.Write($"В полученном массиве присуствует ли искомое число? {FindNumber(myArray, findNum)}");


// Задайте одномерный массив из 12 случайных чисел.
//  Найдите количество элементов массива, значения
//   которых лежат в отрезке [10,99].

int [] CreateRandomArray(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, MaxValue +1);
    }
    return newArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int FindElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100) sum++;
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нимимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size,min,max);
ShowArray(myArray);

int sumElement = FindElements(myArray);
Console.WriteLine($"Колличество двузначных элементов равно: {sumElement}");