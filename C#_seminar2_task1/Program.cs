/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

void foo(int arg)
{
    if (99 >= arg || arg >= 1000)
    {
        Console.WriteLine("Вы ввели число неверного " +
                          "размера\nВведите трёхзначное число: ");
        foo(Convert.ToInt32(Console.ReadLine()));
    }
    else
    {
        Console.WriteLine($"Вторая цифра числа: {arg / 10 % 10}");
    }
}

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

foo(num);
