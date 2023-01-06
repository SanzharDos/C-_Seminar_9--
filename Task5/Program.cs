// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите первое целое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {M} в {N}-й степени равна {Count(M, N)}");
Console.WriteLine($"Число {M} в {N}-й степени через рекурсию равна {CountRec(M, N)}");

int Count(int M, int N)
{
    int count = M;
    while (true)
    {
        count = count * M;
        N--;
        if (N == 1)
            break;
    }
    return count;
}

int CountRec(int M, int N)
{
    if (N == 0) return 1;
    return M * CountRec(M, N - 1);
}