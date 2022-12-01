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

int [] EvenNumbers (int[] array)
{
    int count = 0;
    for(int i = 0; i <= array.Length; i++)
    {
        if(array[i] % 2 ==0)
        {
        count = count + 1;
        }
    }
    Console.WriteLine(count);
    return array;
}

int [] array = new int[10];
FillArray(array);
PrintArray(array);
EvenNumbers(array);*/

// Task 36

void FillArray(int[] collection)
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

int[] SumofElements(int [] array)
{
    
}