// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите колличество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите нимимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) && row1 >= 0 && row2 < array.GetLength(0) && row1 != row2)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }

// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// ChangeRows(myArray, 0, 8);
// Show2dArray(myArray);

// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести 
// сообщение для пользователя.

// int[,] CreateRandom2dArray()
// {
//     int rows = -1;
//     int columns = 0;
//     while (rows != columns)
//     {
//         Console.WriteLine("Обязательное условие: строки и столбцы - равны!");
//         Console.Write("Введите колличество строк: ");
//         rows = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите количество столбцов: ");
//         columns = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.Write("Введите нимимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ReturnArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i > j)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }

// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// ReturnArray(myArray);
// Show2dArray(myArray);

// Из двумерного массива целых чисел удалить строку 
// и столбец, на пересечении которых расположен наименьший элемент.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите колличество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите нимимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] FindIndexMin(int[,] array)
// {
//     int[] indexMin = new int [2];
//     int min = array[0,0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] < min)
//             {
//                 min = array[i,j];
//                 indexMin[0] = i;
//                 indexMin[1] = j;
//             }
//         }
        
//     }
//     return indexMin;
// }

// int[,] DelRowCol(int[,] array, int[] arrayMin)
// {
//     int[,] res = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             if (i >= arrayMin[0] && j >= arrayMin[1]) res[i,j] = array[i + 1,j + 1];
//             else if (i >= arrayMin[0]) res[i,j] = array[i + 1,j];
//             else if (j >= arrayMin[1]) res[i,j] = array[i,j + 1];
//             else res[i,j] = array[i,j];
//         }
//     }
//     return res;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// int[] indexMin = FindIndexMin(myArray);
// int[,] result = DelRowCol(myArray, indexMin);
// Show2dArray(result);

// Написать программу поэлементного копирования массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите колличество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите нимимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] CopyArray(int[,] array)
// {
//     int[,] copy = new int [array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < copy.GetLength(0); i++)
//     {
//         for (int j = 0; j < copy.GetLength(1); j++)
//         {
//             copy[i,j] = array[i,j];
//         }
//     }
//     return copy;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// int[,] result = CopyArray(myArray);
// Show2dArray(result);