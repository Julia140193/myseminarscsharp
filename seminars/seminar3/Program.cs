// Task 1

/*int FindQuart(double x, double y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;

    return 0;
}
Console.WriteLine("Input coordinate X");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y");
double y = Convert.ToDouble(Console.ReadLine());
int result = FindQuart(x, y);
Console.WriteLine($"Quart number of our point is {result}");*/

// Task 2

/*void FindCoordinates(int quart)
{
    if(quart < 1 || quart > 4)
    Console.WriteLine("Такой четверти не существует!");
    if (quart == 1)
    Console.WriteLine("Диапазон координат в I четверти (x>0; y>0)");
    if (quart == 2)
    Console.WriteLine("Диапазон координат в II четверти (x<0; y>0)");
    if (quart == 3)
    Console.WriteLine("Диапазон координат в III четверти (x<0; y<0)");
    if (quart == 4)
    Console.WriteLine("Диапазон координат в IV четверти (x>0; y<0)");
}

Console.WriteLine("Введите номер четверти : ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinates(quart);*/

// Task 3

/*double Line(double x1, double x2, double y1, double y2)
{
    double Len = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
    Console.WriteLine(Len);
    return Len;
}
Console.WriteLine("Введите координату x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Line(x1, x2, y1, y2);*/

// Task 4

/*void Quad (int n)
{
    for(int i = 1; i <= n; i++)
    {
        int result = i*i;
        Console.WriteLine($"{i} - {i*i}");
    }
}
Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
Quad(n);*/
