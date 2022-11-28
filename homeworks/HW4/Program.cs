// Task 25

int FindDegree (int x1, int x2)
{
    for (int count = 1; count <= x2; count++)
    {
        int degree = 1;
        degree = degree * x1;
    }
    return degree;
}


Console.WriteLine("Input number A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B ");
int B = Convert.ToInt32(Console.ReadLine());
int degree = FindDegree(A,B);

if (B > 0)
{
    FindDegree (A, B);
    Console.WriteLine(degree);
}
else
{
    Console.WriteLine("Invalid Value");
}
