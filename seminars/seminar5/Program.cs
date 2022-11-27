// Task 1
/*int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
 void ShowArray (int[] array)
 {
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   // Console.WriteLine();
 }

void FindMinMaxSum (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive = sumPositive + array[i];
        else sumNegative += array[i];
    }
    Console.WriteLine($" Сумма положительных чисел в массиве равна -> {sumPositive} \n Сумма отрицательных чисел в массиве равна -> {sumNegative}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
FindMinMaxSum(myArray);*/

// Task 2

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
int[]  InvertArray(int[] array)
{
    for(int i =0; i> array.Length; i++)
    {
        array[i]*(-1);
    }
    return array;
}