// Task 47

/*double [,] Create2RandomDArray (int rows, int columns, double minValue, double maxValue)
{
    double [,] newArray = new double [rows, columns]; 
    
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            newArray[i,j] = Math.Round(minValue + rand.NextDouble()*(maxValue - minValue), 2);
        }
    }
    return newArray;
}


void Show2DArray (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
double min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
double max = Convert.ToDouble(Console.ReadLine());

double [,] myArray = Create2RandomDArray(rows,columns, min, max);
Show2DArray(myArray);*/

// Task 50

/*int [,] Create2RandomDArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            newArray[i,j] = new Random(). Next(minValue, maxValue+1);
        }
    }
    return newArray;
}

void Show2DArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void FindValueij (int [,] array, int iPosition, int jPosition)
{ 
    if(iPosition > array.GetLength(0) || jPosition > array.GetLength(1))
    {
        Console.WriteLine("There is no element in created array");
    }
    else
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j<array.GetLength(1); j++)
            {
                if (i == iPosition && j == jPosition) 
                {
                    Console.WriteLine($"{array[i,j]}");
                }
            }
        }
    }    
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите i-ую позицию элемента");
int iPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите j-ую позицию элемента");
int jPosition = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2RandomDArray(rows,columns, min, max);
Show2DArray(myArray);
Console.WriteLine();
FindValueij(myArray, iPosition, jPosition);*/

// Task 52

/*int [,] Create2RandomDArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            newArray[i,j] = new Random(). Next(minValue, maxValue+1);
        }
    }
    return newArray;
}

void Show2DArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void AverageofColumns (int [,] array)
{
    double sum = 0;
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        avg = sum / array.GetLength(1);
        Console.WriteLine($"{Math.Round(avg, 2)} ");
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2RandomDArray(rows,columns, min, max);
Show2DArray(myArray);
Console.WriteLine();
AverageofColumns(myArray);*/