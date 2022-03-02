/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

void numberDayWeek(int arg)
{
    if (arg == 6 || arg == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        if (arg < 6)
        {
            Console.WriteLine("Нет");
        }
        else
        {
            Console.WriteLine("Вы ввели неверную цифру" +
                              "\nВведите номер дня недели от 1 до 7 " +
                              "чтобы узнать является ли он выходным:");
            arg = Convert.ToInt32(Console.ReadLine());
            numberDayWeek(arg);
        }
    }
}
Console.WriteLine("Введите номер дня недели от 1 до 7 " +
                  "чтобы узнать является ли он выходным:");
int num = Convert.ToInt32(Console.ReadLine());
numberDayWeek(num);
