/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/
Console.WriteLine("Введите цифры массива");
string[] array = Console.ReadLine().Split(",");
if (array.Length != 8)
{
    Console.WriteLine("Введено не 8 элементов");
    return;
}
int[] finishArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    finishArray[i] = Int32.Parse(array[i]);
}

Console.WriteLine("[{0}]", string.Join(",", finishArray));