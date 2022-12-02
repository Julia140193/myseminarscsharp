// Task 34

/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    
    for(int i = 0; i< count; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

void EvenNumbers (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0)
        {
        count = count + 1;
        }
    }
    Console.WriteLine(count);
}

int [] array = new int[10];
FillArray(array);
PrintArray(array);
EvenNumbers(array);*/

// Task 36

/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    
    for(int i = 0; i< count; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

void SumofElements (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
         sum = sum +array[i];
        }
    }
    Console.WriteLine(sum);
}

int [] array = new int[10];
FillArray(array);
PrintArray(array);
SumofElements(array);*/

// Task 38

/*void FillArray(double [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    
    for(int i = 0; i< count; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

void FindMinMaxDiff (double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    double diff = 0;
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];
        else
        {
            if(array[i] > maxValue) 
            {
                maxValue = array[i];
            }
        }
    }
    diff = maxValue - minValue;
    Console.WriteLine($" Разница между максимальным и минимальным элементами равна -> {diff}");
}

double [] myArray = new double[10];
FillArray(myArray);
PrintArray(myArray);
FindMinMaxDiff(myArray);*/