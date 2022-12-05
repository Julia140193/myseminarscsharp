// Task 64

/*void ShowNumbers(int n)
{
    if(n>=1)
    {
        Console.Write(n+" ");
        ShowNumbers(n-1);
    }
}
Console.WriteLine ("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);*/

// Task 66

/*int FindSum (int m, int n)
{
   if(m == n) return m;
   if (m > n)
        {
            return m + FindSum(m -1, n); 
        }
    else
        {
            return n + FindSum(m, n-1);
        }
}
Console.WriteLine ("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSum(m,n));*/
 

 // Task 68

/*int Akkerman (int m, int n)
{
    if(m==0)
    {
        return n+1;
    }
    else
    {
        if(n==0 && m > 0)
        {
            return Akkerman(m-1, 1);
        }
        else
        {
            return Akkerman(m-1, Akkerman(m, n-1));
        }
    }
}

Console.WriteLine ("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if(m >0 && n > 0)
{
    Console.WriteLine(Akkerman(m,n));
}
else
{
    Console.WriteLine("Введите числа больше нуля, иначе программа не заработает");
}*/









