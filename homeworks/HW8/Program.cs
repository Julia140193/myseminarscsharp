// Task 54 получилось

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
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1)-1; j++)
        {
            for(int n=0; n < array.GetLength(1)-1; n++)
            {
                if(array[i,n] < array[i, n+1])
                {
                    int temp = 0;
                    temp = array[i,n];
                    array[i,n] = array[i,n+1];
                    array[i,n+1] = temp;
                }
            }
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
Show2DArray(newArray);*/

// Task 56 получилось

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(sum < min) 
        {
            min = sum;
            no++;
        }
        Console.Write($"{sum}" + " "); // можно сумму и не выводить, но для удобства проверки оставим
    }
    Console.WriteLine();
    Console.WriteLine($"{no}");
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

if(rows==columns)
{
    Console.WriteLine("Введите прямоугольный массив, то есть строки не должны быть равны столбцам");
}
else
{
    int [,] myArray = Create2RandomDArray(rows,columns, min, max);
    Show2DArray(myArray);
    Console.WriteLine();
    SumofRows(myArray);
}*/


// Task 58 получилось

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

// Task 60 не получилось

// Task 62 получилось

/*Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] a = new int[rows, columns];
int r = 0;
int c = 0;
for(c = 0; c < columns; c++)
{
    for(r = 0; r< rows; r++)
    {
        a[r,c] = 0;
    }
}
int dir = 0;
int k = 0;
for(r=c=dir=k=0; k < rows*columns; )
{
    a[r,c] = ++k;
    if(k==rows*columns) break;

    while(true) 
        {
            if(dir==0) 
            {
                if(c+1<columns) 
                    if(a[r,c+1]==0) 
                    {
                        ++c;
                        break;
                    }
                dir= 1;
                
            } 
            else if(dir==1) 
            {
                if(r+1<rows) 
                    if(a[r+1,c]==0) 
                    {
                        ++r;
                        break;
                    }
                dir= 2;
                
            } 
            else if(dir==2) 
            {
                if(c-1>=0) 
                    if(a[r,c-1]==0) 
                    {
                        --c;
                        break;
                    }
                dir= 3;

            } 
            else if(dir==3) 
            {
                if(r-1>=0) 
                    if(a[r-1,c]==0) 
                    {
                        --r;
                        break;
                    }
                dir= 0;
                
            }
        }
    }
    
    for(r= 0; r<rows; r++) 
    {
        for(c= 0; c<columns; c++) 
        {
            Console.Write("{0,3:D2}", a[r,c]);
        }
        Console.WriteLine(" ");
    }*/