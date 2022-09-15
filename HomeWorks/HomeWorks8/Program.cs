// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortRows(int[,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
        for (int i = 0; i < array.GetLength(0); i++)        
            for (int j = 1; j < array.GetLength(1); j++)           
                if (array[i ,j - 1] < array[i,j])
                {
                    int temp = array[i ,j - 1];
                    array[i ,j - 1] = array[i,j];
                    array[i,j] = temp;
                }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortRows(myArray);
Show2dArray(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int[] SumRow (int[,] array)
{
    int[] sumArr = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumArr[i] += array[i,j];
    return sumArr;
}

int NumRow (int[] array)
{
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) 
        {
            row = i;
            min = array[i];
        }
    return row;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] sum = SumRow(myArray);
int result = NumRow(sum);
Console.WriteLine($"Строка № {result + 1} имеет самую минимальную сумму элементов!");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

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

int[,] MultiplicatArray(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int k = 0; k < newArray.GetLength(0); k++)
        for (int l = 0; l < newArray.GetLength(1); l++)
            for (int j = 0; j < array1.GetLength(1); j++)
                newArray[k,l] += array1[k,j]*array2[j,l];                                
    return newArray;
}

int[,] my1Array = CreateRandom2dArray();
int[,] my2Array = CreateRandom2dArray();
Show2dArray(my1Array);
Show2dArray(my2Array);
if(my1Array.GetLength(1) != my2Array.GetLength(0))
{
    Console.WriteLine("Данные матрицы нельзя умножить!");
    Console.WriteLine("Количество столбцов первой, должно равняться количеству строк второй!");
}
else 
{
    int[,] result = MultiplicatArray(my1Array, my2Array);
    Console.WriteLine("Результат умножения первой матрицы на вторую:");
    Show2dArray(result);
}
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                newArray[i,j,k] = new Random().Next(10, 100);
            }

        }

    }     
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}[{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMistake(int[,,] array)
{
    int current = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                int temp = array[x,y,z];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            if(temp == array[i,j,k] && !(i == x && j == y && k == z))
                            {
                                array [x,y,z] = new Random().Next(10, 100);
                                current++;
                            }
                        }
                    }
                }
            }
        }

    }
return current;
}

int[,,] myArray = CreateRandom3dArray();
int n = FindMistake(myArray);
for (int i = 0; n != 0 && i < 5; i++)
{
    n = FindMistake(myArray);
    if(i >= 4 && n > 0)
    {
        Console.WriteLine("Возможно нет возможности заполнить массив уникальными двузначными числами!");
    }
}
Console.WriteLine($"Найдено {n} одинаковых элементов!");
Show3dArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());


    int[,] newArray = new int[rows, columns];
    int current = 1;
    for (int i = 0; i < columns; i++) 
    {
        newArray[0,i] = current;
        current++;
    }
    for (int i = 1; i < rows; i++) 
    {
        newArray[i,rows -1] = current;
        current++;
    }
    for (int i = columns -2; i >= 0; i--) 
    {
        newArray[rows -1,i] = current;
        current++;
    }
    for (int i = rows -2; i > 0; i--)
    {
        newArray[i,0] = current;
        current++;
    }
    for (int i = 1; i < columns-1; i++) 
    {
        newArray[1,i] = current;
        current++;
    }
    for (int i = 2; i < rows-1; i++) 
    {
        newArray[i,rows -2] = current;
        current++;
    }
    for (int i = columns -3; i > 0; i--) 
    {
        newArray[rows - 2,i] = current;
        current++;
    }
    for (int i = rows -3; i >= 2; i--) 
    {
        newArray[i,1] = current;
        current++;
    }
    for (int i = 2; i <= columns-3; i++) 
    {
        newArray[2,i] = current;
        current++;
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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/