// Task 54

/*int [,] Create2RandomDArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int[rows, columns]; //выделяем память для массива
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
    Console.WriteLine();
}

int [,] ChangeElements (int [,] array)
{

}




Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2RandomDArray(rows,columns, min, max);
Show2DArray(myArray);*/

// Task 56

int [,] Create2RandomDArray (int rows, int columns, int minValue, int maxValue)
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

void SumofRows (int [,] array)
{
    int no = 0;
    int sum = 0;
    int min = 0;
    for (int j =  sum = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[0,j];
        int minsum = SumofRows;
        no = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = sum = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(sum < minsum) 
        {
            minsum = sum;
            no = i;
        }
        Console.WriteLine($"{sum}");
        Console.WriteLine($"{i}");
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
SumofRows(myArray);
