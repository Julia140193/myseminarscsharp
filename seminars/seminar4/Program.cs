// Task 1

/*int FindSum(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindSum(number);
Console.WriteLine(result);*/

// Task 3

/*int Factorial (int a)
{
    int fact = 1;
    for(int i = 2; i <= a; i++)
    {
        fact =  fact * i;
    }
    return fact;
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine(result);*/

// Task 2

/*int Count (int x)
{
    int a = 0;
    while(x>0)
    {
      x = x / 10;
      a++;
    }
    return a;
}

Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
int result = Count(a);
Console.WriteLine(result);*/

// Task 4

/*int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray = new int [size];
   for (int i = 0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a,min, max);
ShowArray(myArray);*/