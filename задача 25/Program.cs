/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

void GetNumb(int a, int b)
{
    Console.Write($"{a} в степени {b} = ");
 
    double degree = Math.Pow(a, b);
    Console.Write($"{degree}, ");
}

Console.WriteLine("Введите число А и B: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
GetNumb(a, b);