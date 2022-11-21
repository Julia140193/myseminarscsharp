// Task 1

/*int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if(ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}

int random = new Random(). Next(10,100);
int result = FindBiggestDigit(random);
Console.WriteLine($"Your number -> {random}");
Console.WriteLine($"The biggest digit -> {result}");*/

// Task 2

/*int CutNumber (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int res = sot * 10 + ed;
    return res;
}
int random = new Random(). Next(100,1000);
int newnumber = CutNumber(random);
Console.WriteLine($"New version of {random} is {newnumber}");*/

// Task 3

/*void IsDiv(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine($"number {num2} {num1} -> devisible");
    }
    else
    {
        Console.WriteLine($"number {num2} {num1} -> not devisible {num2 % num1}");
    }
}

int a = 5;
int b = 35;
IsDiv(a,b);*/

// Task 4

/*bool IsDiv(int num)
{
    if ((num % 7 == 0 )&& ( num % 23 ==0))
    {
        return true;
    }
    else
    {
       return false;
    }
}

int a = 161;
bool b = IsDiv(a);
Console.WriteLine(b);*/

