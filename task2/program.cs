// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return SumNumbers(M,N-1)+N;
}
System.Console.WriteLine(SumNumbers(1,3));


