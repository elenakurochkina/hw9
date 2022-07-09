//Задайте значения M и N. Напишите программу, которая выведет все 
//чётные натуральные числа в промежутке от M до N с помощью рекурсии

void PrintNatural(int N, int M)
{
    if (M < N)
    {
        return;
    }
    if (N%2==0)
{
    System.Console.Write($"{N}; ");
}
    PrintNatural(N + 1, M);
}

PrintNatural(2, 20);
