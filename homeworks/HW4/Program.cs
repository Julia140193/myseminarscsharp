// Task 25

/*int FindDegree (int x1, int x2)
{
    int degreeRes = 1;
    for (int count = 1; count <= x2; count++)
    {
        degreeRes = degreeRes * x1;
    }
    return degreeRes;
}

Console.WriteLine("Input number A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B ");
int B = Convert.ToInt32(Console.ReadLine());
int degreeRes = FindDegree(A, B);
Console.WriteLine(degreeRes);

if (B > 0)
{
    FindDegree (A, B);
}
else
{
    Console.WriteLine("Invalid Value");
}*/

// Task 27

/*int FindSumDigits(int A)
{
    int sum = 0;
    while (A > 0)
    {
        sum = sum + (A % 10);
        A = A / 10;
    }
    return sum;
}
Console.WriteLine("Input number A ");
int A = Convert.ToInt32(Console.ReadLine());
int result = FindSumDigits(A);
Console.WriteLine(result);*/

// Task 29 (так и не поняла, как красиво вывести массив: в [] и через запятую)

/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 100); // скобки после Next можно оставить и пустыми, но тогда рандомно выскакивуют очень большие числа
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

int [] array = new int[8];
FillArray(array);
PrintArray(array);*/