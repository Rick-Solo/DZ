﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A + "^" + B + "=" + Stepen(A,B));

// double Stepen(int A, int B)
// {
//     double result = 1;
//     int i = 0;
//     while (i< Math.Abs(B))
//         {result = result * A;
//          i ++;}
//     return result;
// }
// --------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum= "+ Metod(A));

int Metod(int A){
    int count = Convert.ToString(A).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        temp = A - A%10;
        result = result + (A - temp);
        A = A / 10;
    }
    return result;
}
