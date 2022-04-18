// Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.

Console.WriteLine();
Console.Write("Введите номер года: ");
int year = Convert.ToInt32(Console.ReadLine());

if (LeapYear(year))
{
    Console.WriteLine($"{year} год является високосным.");
}
else Console.WriteLine($"{year} год не является високосным.");
Console.WriteLine();


bool LeapYear(int number, int del = 4, bool result = true)
{
    if (del == 4 && number % del == 0)
    {
        LeapYear(number, del = 100, result = true);
    }
    if (del == 100 && number % del != 0) return result = true;
    else return result = false;
}