// Task 1

// создаем массив

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
// метод для решения задачи

int [] ReverseArray (int[] array)
{
    for(int i = 0, j = array.Length - 1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

Console.WriteLine("введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размер массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размер массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(ReverseArray(myArray));*/

// Task 2

/*bool CheckTriangle(int a, int b, int c)
{
    if(a+b>c && b+c>a && a+c>b)
    return true;
    return false;
}

//запрос числа у пользователя и если не подходит число, то будем запрашивать заново

int CheckNumber()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if(x <=0 ) return CheckNumber();
    else return x;
}

Console.WriteLine("Input Length A:");
int a = CheckNumber();
Console.WriteLine("Input Length B:");
int b = CheckNumber();
Console.WriteLine("Input Length C:");
int c = CheckNumber();

Console.WriteLine(CheckTriangle(a,b,c));*/

// Task 3

/*void Fibonacci(int a, int b, int n)
{
    int[] array = new int [n];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-2] + array[i-1];
        Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Input first Fibonacci:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second Fibonacci:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input next Fibonacci:");
int n = Convert.ToInt32(Console.ReadLine());

Fibonacci(a,b,n);*/

// Task 4

/*string TeninTwo(int n)
{
    string result = string.Empty;
    while(n > 0)
    {
        result = ((n % 2 ==0) ? "0" : "1") + result;
        n = n / 2;
    }
    return result;
}

Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
string Temp = TeninTwo(n);
Console.WriteLine(Temp);*/