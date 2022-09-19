// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumsMN(int m, int n)
{
    if (m <= n) return SumNumsMN(m, n - 1) + n;
    else return 0;
}
Console.Write("Введите первое число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM < numN)
{
    int result = SumNumsMN(numM, numN);   
    Console.Write($"Сумма всех элементов между {numM} и {numN} равна {result}!"); 
}
else
{
    int result = SumNumsMN(numN, numM);
    Console.Write($"Сумма всех элементов между {numM} и {numN} равна {result}!");
} 
*/
// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    else if ( m > 0 && n == 0) return Akkerman(m-1,1);
    else if (m>0 && n>0) return Akkerman(m-1, Akkerman(m,n-1));
    else return 0;
}
Console.WriteLine("Вычислим функцию Аккермана для чисел: M и N!");
Console.Write("Введите число 'M': ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'N': ");
int numN = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(numM,numN);
Console.Write($"A({numM}, {numN}) = {result}");
*/