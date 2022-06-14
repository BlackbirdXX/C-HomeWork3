// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;
Clear();

WriteLine("Введите координаты точек А и В:");
Write("Координата xa: ");
int xa = Convert.ToInt32(ReadLine());

Write("Координата ya: ");
int ya = Convert.ToInt32(ReadLine());

Write("Координата za: ");
int z1 = Convert.ToInt32(ReadLine());

Write("Координата xb: ");
int x2 = Convert.ToInt32(ReadLine());

Write("Координата yb: ");
int y2 = Convert.ToInt32(ReadLine());

Write("Координата zb: ");
int z2 = Convert.ToInt32(ReadLine());

// A B | = √ (( x B − x A ) 2 + ( y B − y A ) 2 + ( z B − z A ) 2)

double distance = Math.Sqrt(Math.Pow(x2-xa,2) + Math.Pow(y2-ya,2) + Math.Pow(z2-z1,2));
WriteLine($"Расстояние между точками в пространстве равно: {distance:f2}");
