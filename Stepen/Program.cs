/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

using static System.Console;
Clear();

WriteLine("Введите число А:");
double a = Convert.ToDouble(ReadLine());
WriteLine("Введите число B:");
double b = Convert.ToDouble(ReadLine());

double pow = GetPow(a, b);
WriteLine($"Число {a} в степени {b} равно {pow}");


double GetPow (double arg1, double arg2)
{
    double result = Math.Pow(arg1, arg2);
    return result;
}