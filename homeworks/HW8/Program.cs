// Task 54

int [,] Create2RandomDArray (int rows, int columns, int minValue, int maxValue)
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
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
        }    
    }
    return array;
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
Show2DArray(myArray);
int [,] newArray = ChangeElements(myArray);
Show2DArray(newArray);

// Task 56

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
SumofRows(myArray);*/

// Task 58

/*int [,] CreateRandomArray1 (int rows, int columns, int minValue, int maxValue)
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


void ShowArray1 (int [,] array)
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

int [,] CreateRandomArray2 (int rows, int columns, int minValue, int maxValue)
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


void ShowArray2 (int [,] array)
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

int [,] MatrixProduct (int [,] array1, int [,] array2)
{
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Error, please specify equel matrices");
    }
    else
    {
        int [,] prod = new int [array1.GetLength(0), array2.GetLength(1)];
        for (int i= 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    prod[i,j] += array1[i, k]* array2[k, j];
                }
            }
        }
        return prod;
    }  
    return array1;
}

void ShowArray3 (int [,] prod)
{
    for(int i = 0; i < prod.GetLength(0); i++)
    {
        for (int j = 0; j<prod.GetLength(1); j++)
        {
            Console.Write(prod[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента первой матрицы");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента первой матрицы");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента второй матрицы");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента второй матрицы");
int max2 = Convert.ToInt32(Console.ReadLine());

int [,] myArray1 = CreateRandomArray1(rows1, columns1, min1, max1);
int [,] myArray2 = CreateRandomArray2(rows2, columns2, min2, max2);

ShowArray1(myArray1);
ShowArray2(myArray2);
Console.WriteLine();
int [,] prod = MatrixProduct(myArray1, myArray2);
ShowArray3(prod);*/