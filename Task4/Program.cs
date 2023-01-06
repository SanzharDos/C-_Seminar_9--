// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {N} равна {Summa(N)}");
Console.WriteLine($"Сумма цифр числа {N} через рекурсию равна {SummaRec(N)}");

int Summa(int N)
{
    int sum = 0;
    while (true)
    {
        sum = sum + N % 10;
        N = N / 10;
        if (N == 0)
            break;
    }
    return sum;
}

int SummaRec(int N)
{
    if (N == 0) return 0;
    return N % 10 + SummaRec(N / 10);
}

