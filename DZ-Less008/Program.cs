// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Урок 8. Двумерные массивы. Продолжение");
void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }

    }
}
void PrintArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]}\t");
        }
        Console.WriteLine();
    }
}
//Console.Write("Задайте число строк от 3 до 10 - \t\t");
int A = 3; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Задайте число колонок от 3 до 10 - \t\t");
int B = 5; //Convert.ToInt32(Console.ReadLine());
int[,] Matrix2 = new int[A, B];

FillArray(Matrix2);
PrintArray(Matrix2);
Console.WriteLine();
/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.WriteLine("Задача 54");


/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */