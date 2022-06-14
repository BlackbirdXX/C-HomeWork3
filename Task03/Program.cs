// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;
using static System.Console;
Clear();
WriteLine("Вывод таблицы кубов, чисел от 1 до N");
WriteLine("Введите число N");
int n = Convert.ToInt32(ReadLine());
for (int ctr=0; ctr <=n; ctr++)
{
    if (ctr == n) Write(Math.Pow(ctr,3)); 
    else {
        double sqr = Math.Pow(ctr,3);
        Write($"{sqr}, ");
    }
}
WriteLine("\nКонец программы.");