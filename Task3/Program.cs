// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое целое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int N = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (M > N)
{
    max = M;
    min = N;
}
else
{
    max = N;
    min = M;
}

Console.WriteLine($"Все натуральные числа в промежутке от {min} до {max} составляют: {Count(min, max)}");
Console.WriteLine($"Все натуральные числа в промежутке от {min} до {max} составляют: {PrintNum(min, max)}");

string Count(int min, int max)
{
    if (max == min) return Convert.ToString(min) + ", ";
    else if (max > min + 1) return Count(min, max - 1) + ", " + max;
    return Count(min, max - 1) + max;
}

string PrintNum(int min, int max)
{
    string res = "";
    while (true)
    {
        if (max > min)
        {
            res = ", " + max + res;
            max--;
        }
        else if (max == min)
        {
            res = max + res;
            max--;
        }
        else if (max < min)
            break;
    }
    return res;
}