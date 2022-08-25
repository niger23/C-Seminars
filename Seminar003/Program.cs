// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.
/*
int FindQuadrant(double x, double y)

{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);
*/
// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой 
//  четверти (x и y).
/*
void Diaposon(int number)
{
    if (number == 1) Console.WriteLine("x > 0 и y > 0");
    if (number == 2) Console.WriteLine("x < 0 и y > 0");
    if (number == 3) Console.WriteLine("x < 0 и y < 0");
    if (number == 4) Console.WriteLine("x > 0 и y < 0");
    if (number < 1 || number > 4) Console.WriteLine("Не существует четверти с таким числом");
}
Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
Diaposon(num);
*/

// Напишите программу, которая принимает на вход число (n) 
// и выдаёт квадраты чисел от 1 до n.
/*
void Quadr(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.Write(current*current + " ");
        current++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Quadr(num);
*/

// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double xA, double yA, double xB, double yB)
{
    double katet1 = xA - xB;
    double katet2 = yA - yB;
    double dist = Math.Sqrt(katet1*katet1 + katet2*katet2);
    return dist;
}
Console.Write("Input x coordinate, first point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate, first point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate, second point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate, second point: ");
double yB = Convert.ToDouble(Console.ReadLine());

double distance = Distance(xA, yA, xB,yB);
Console.Write("Расстояние между точками равно " + distance);
