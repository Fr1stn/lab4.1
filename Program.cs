using System;

Console.WriteLine("Сколько чисел вы хотите ввести?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа:");
int nums = 0;
int i = 0;
while (i < n)
{
    i++;
    if (Convert.ToInt16(Console.ReadLine()) % 2 == 1)
    {
        nums++;
    }
}
Console.WriteLine($"Всего нечетных чисел: {nums}");