
/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
Console.WriteLine($"Quad of {num} -> {quad} ");*/


/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;
if (quad == num1)
{
    Console.WriteLine($"{num1} is quad of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not quad of {num2}");
}*/


/*Console.WriteLine("Input number N");
int N = Convert.ToInt32(Console.ReadLine());
int count = N * (-1);
while (count !<= N)
{
Console.WriteLine(count);
count++;
}*/


Console.WriteLine("Input number N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Abs(N) % 10);
