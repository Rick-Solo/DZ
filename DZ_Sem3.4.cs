// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A + "^" + B + "=" + Stepen(A,B));

double Stepen(int A, int B)
{
    double result = Math.Pow(A,B);
    return result;
}
