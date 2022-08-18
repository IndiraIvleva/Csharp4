/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

using static System.Console;
Clear();

WriteLine("Введите минимальный диапазон массива: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите максимальный диапазон массива: ");
int b = Convert.ToInt32(ReadLine());
int size = 8;
int[] array = GetArray(size, a, b);
WriteLine($"[{String.Join(",", array)}]");



int[] GetArray(int number, int min, int max)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

//ВТОРОЕ РЕШЕНИЕ


WriteLine("Второе решение:");
WriteLine("Введите 8 чисел через пробел");
string[] arrayString = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[] array1 = new int[arrayString.Length];
if (arrayString.Length == 8)
{
    for (int i = 0; i < arrayString.Length; i++)
    {
        array1[i]=Convert.ToInt32(arrayString[i]);
    }

    WriteLine($"[{String.Join(",", array1)}]");
}
else
WriteLine("Количество элементов не равно 8");