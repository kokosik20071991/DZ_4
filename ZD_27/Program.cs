﻿Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;


    while (a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
}
Console.WriteLine($"Cумма всех цифр в числе равна: {sum} ");