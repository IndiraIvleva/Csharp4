/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

using static System.Console;
Clear();

WriteLine("Введите число:");
int a = Convert.ToInt32(ReadLine());
int[] DigitArray = GetDigit(a);
WriteLine($"[{String.Join(",", DigitArray)}]");
WriteLine($"Сумма цифр числа {a} равна {SumDigit(DigitArray)}");

int[] GetDigit(int num)
{
    int size = 0;
    int temp = num;
    while ((temp/10) > 0)       // (temp/10) для того, чтобы при выводе массива цифр из числа, не выходил 0
    {
        temp /= 10;
        size += 1;
    }                             // узнаем сколько элементов массива получится из заданного числа

    int[] digit = new int[size + 1];   // кол-во элементов +1 - это размер массива
    for (int i = size; i >= 0; i--)
    {
        digit[i] = num % 10;
        num = num / 10;              // делим число с остатком на 10, остаток записываем в элемент массива с конца
    }
    return digit;
}


int SumDigit(int[] Mass)
{
    int sum = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        sum += Mass[i];
    }
    return sum;
}
