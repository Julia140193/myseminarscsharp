// Task 41

/*int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for(int i = 0; i<size; i++)
    {
        newArray[i] = new Random(). Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray( int [] array)
{
    Console.Write($"Получившийся массив -> ");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
    Console.WriteLine();
}

int [] Quantity (int [] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"{count}");
    return array;
}

Console.WriteLine("введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);
ShowArray(Quantity(myArray));*/

// Task 43
/*int FindPointCoordinates (int k1, int b1, int k2, int b2)
{
    int x = 0;
    int y = 0;
    if(k1 == k2)
    {
        Console.WriteLine("There is no point of intersection");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1*((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"({x};{y})");
    }
    return x;
}


Console.WriteLine("введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());

FindPointCoordinates(k1, b1, k2, b2);*/