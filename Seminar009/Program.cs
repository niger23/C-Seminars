// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums (int n)
// {
//     if(n > 1) 
//     {
//         Console.Write(n + " ");
//         ShowNums(n-1);
//     }
//     Console.Write(n + " ");
// }
// ShowNums(5);

// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

// int SumofDigits(int n)
// {
//     if(n > 0) return SumofDigits(n/10) + n % 10;
//     else return 0;
// }

// Console.WriteLine(SumofDigits(5364));


// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// void ShowsNumsMN (int m, int n)
// {
//     if(m<n) ShowsNumsMN(m, n-1);

//     Console.Write(n+ " ");
// }
// int numM =1;
// int numN = 15;
// ShowsNumsMN(numM,numN);

// Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B
//  с помощью рекурсии.

// int PowerAtoB(int a, int b)
// {
//     if(b >= 1) return PowerAtoB(a, b -1)*a;
//     else return 1;
// }
// int numM =2;
// int numN = 10;
// Console.WriteLine(PowerAtoB(numM,numN));