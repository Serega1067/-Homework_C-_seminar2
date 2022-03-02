/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
*/

void findDigitNumber(int arg1, int arg2)
{
    string numString = Convert.ToString(arg1);
    int numLen = numString.Length;
    if (numLen < arg2)
    {
        Console.WriteLine($"{arg2} цифры нет");
    }
    else
    {
        int temp = Convert.ToInt32(
            Math.Pow(10, numLen - arg2));
        int result = (arg1 / temp % 10);
        Console.WriteLine(result);
    }
}

Console.WriteLine("Введите какую по счёту цифру от 1 до 10 нужно найти:");
int numCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, не больше 10 знаков, в котором" +
                  $"\nнужно найти {numCount} по счёту цифру:");
int num = Convert.ToInt32(Console.ReadLine());

findDigitNumber(num, numCount);
