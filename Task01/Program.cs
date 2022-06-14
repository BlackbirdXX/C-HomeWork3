// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
using static System.Console;
Clear();

WriteLine("Введите пятизначное число");
if(!int.TryParse(ReadLine(),out int n))
{
    WriteLine("Ошибка ввода числа!");
    return;
}
if ((99999<n)||(n<10000))
{
    WriteLine("Ошибка ввода числа!");
    return;
}

int imputNumber = n;
int reverseNumber = 0;

while (n > 0)
{
    int curentNumber = n % 10;
    reverseNumber = reverseNumber * 10 + curentNumber;
    n = n / 10;
}
if (imputNumber == reverseNumber)
{
    WriteLine($"Да, число {imputNumber} является палиндромом числа {reverseNumber}.");
}
else WriteLine ($"Нет, числа {imputNumber} и {reverseNumber}, палиндромами не являются.");

