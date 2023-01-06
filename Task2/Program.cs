// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите целое число");
double N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все натуральные числа в промежутке от 1 до {N} составляют: {Count(N)}");
Console.WriteLine($"Все натуральные числа в промежутке от 1 до {N} составляют: {PrintNum(N)}");

string Count(double N)
{
    if (N == 0) return "";
    else if (N > 1) return Count(N - 1) + ", " + N;
    return Count(N - 1) + N;
}

string PrintNum(double N)
{
    string res = "";
    while (true)
    {
        if (N > 1)
        {
            res = ", " + N + res;
            N--;
        }
        else if (N > 0)
        {
            res = N + res;
            N--;
        }
        else if (N == 0)
            break;
    }
    return res;
}