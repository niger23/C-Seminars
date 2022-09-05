//Напишите программу, которая перевернёт одномерный 
//массив (последний элемент будет на первом месте, а 
//первый - на последнем и т.д.)

// int[] CreateRandomArray(int size, int minValue, int MaxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, MaxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int [] array)
// {
//     for (int i = 0, j = array.Length -1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нимимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// myArray = ReverseArray(myArray);
// ShowArray(myArray);

// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.

// bool Possible (int num1, int num2, int num3)
// {
//     bool result = false;
//     if (num1 < num2 +num3 && num2 < num1 + num3 && num3 < num1 + num2)
//     {
//         result = true;
//     }
//     return result;
// }
// Console.WriteLine("Проверим возможен ли треугольник с вашими сторонами!");
// Console.Write("Первая сторона треугольника равна: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Вторая сторона треугольника равна: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Третья сторона треугольника равна: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Возможен ли треугольник с вашими сторонами: {Possible(num1, num2, num3)}");

// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b.

// void Fibonacci (int a, int b, int n)
// {
//     Console.Write($"{a} {b} ");
//     int temp = 0;
//     for (int i = 0; i < n; i++)
//     {
//         temp = a + b;
//         a = b;
//         b = temp;
//         Console.Write($"{b} ");
//     }
// }

// Console.Write("Введите первое число ряда Фибоначчи: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ряда Фибоначчи: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Fibonacci(num1, num2, n);

// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

string Binary(int num)
{
    string elem = string.Empty;

    while (num > 0)
    {
        int n = num % 2;
        elem = Convert.ToString(n) + elem;
        num = num / 2;
    }
    return elem;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Binary(n);
Console.WriteLine(result);







