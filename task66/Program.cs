// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120


Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
 int sum = 0; 
 if (M > N)
{
   void sunNumber(int n,int m)
    {
        if (m == n - 1)
        {
            return;
        }
        sunNumber(n, m - 1);
        sum = sum + m;
    }
sunNumber(N,M);
Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum} ");
}
else
{
    void sunNumber(int m, int n)
    {
        if (n == m - 1)
        {
            return;
        }
        sunNumber(m, n - 1);
        sum = sum + n;
    }
    sunNumber(M, N);
Console.WriteLine($"Сумма элементов в промежутке от M до N равна:   {sum} ");
}
Console.WriteLine();