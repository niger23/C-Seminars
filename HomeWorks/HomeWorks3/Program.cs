// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
int Size(int number)
{
    if (number < 0) number = -number;
    int size = 0;
    while (number > 0)
    {
        number = number / 10;
        size++;
    }
    return size;
}

void Poli(int number, int size)
{
    int temp = Convert.ToInt32(Math.Pow(10, size - 1));
    int cor = 0;
    while (cor < size / 2)
    {
        int first = number / temp;
        int end = number % 10;
        if (first == end)
        {
            number = number % temp / 10;
            temp = temp / 100;
            cor++;            
        }
        else cor=404;        
    }
    if (cor==size/2) Console.WriteLine("Данное число является палиндромом!");
    else Console.WriteLine("Данное число палиндромом не является!");

}

Console.WriteLine("Проверим является ли ваше число палиндромом!");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sizeNum = Size(num);
Poli(num, sizeNum);
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double kat1 = xA - xB;
    double kat2 = yA - yB;
    double kat3 = zA - zB;
    double dist = Math.Sqrt(kat1 * kat1 + kat2 * kat2 + kat3 * kat3);
    return dist;
}
Console.Write("Input x coordinate, first point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate, first point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z coordinate, first point: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x coordinate, second point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate, second point: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z coordinate, second point: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = Distance(xA, yA, zA, xB, yB, zB);
Console.Write("Расстояние между точками равно " + distance);
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.WriteLine($"The cube of the number {current} is equal to {Math.Pow(current, 3)}");
        current++;
    }
}
Console.WriteLine("Давайте выведем все кубы чисел от 1 до вашего!");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/