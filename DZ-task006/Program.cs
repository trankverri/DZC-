// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var IsEven = (int v) => v % 2 == 0;

// string address = string.Empty;

// Random r= new Random();
// Console.CursorVisible= false;
// while (true)
// {
//     Console.SetCursorPozition(
//         left: r.Next(Console.WindowWidth),
//         top: t.Next(Console.WindowHeigth)
//     );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }

void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 99);
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
// Заполнение массива double
void MassivDouble(double[,] mass, int num)
{
    Random dice = new Random();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = dice.Next(-num, num) + dice.NextDouble();
        }

    }

}
//печать массива double
void PrintMassivDouble(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"[{mass[i, j]:f2}]\t");
        }
        Console.WriteLine();
    }

}

int SummPozitive(int[,] mass)
{
    int SummP = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
            {
                SummP = mass[i, j] * mass[i, j];
                //mass[i, j] = SummP;
            }
    }
    return SummP;
}


int SummDigonal(int[,] mass)
{
    int SummD = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
            if (i == j)
            {
                SummD = SummD + mass[i, j];
            }

    }
    return SummD;
}

void ReversLine(int[,] mass)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        (mass[0, j], mass[mass.GetLength(0) - 1, j]) = (mass[mass.GetLength(0) - 1, j], mass[0, j]);
    }
}

void ArithmeticMean(int[,] mass)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        double sum = 0;
        int i=0;
        //for (int i = 0; i < mass.GetLength(0); i++)
        //{
            sum += mass[i, j];
            i++;

        //}
        sum = sum / mass.GetLength(0);
        Console.Write($"{sum:f2}\t");
    }
}

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int[,] Matrix2 = new int[A, B];

FillArray(Matrix2);
PrintArray(Matrix2);
Console.WriteLine();
SummPozitive(Matrix2);
int W = SummDigonal(Matrix2);
Console.WriteLine($"summ glavnoy diogal {W} ");
Console.WriteLine($"поменяли первую строку с последней");
ReversLine(Matrix2);
PrintArray(Matrix2);
Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50");
//int AA = 5; //Convert.ToInt32(Console.ReadLine());
//int BB = 8; //Convert.ToInt32(Console.ReadLine());
// int[,] Matrix50 = new int[AA, BB];
// FillArray(Matrix50);
// PrintArray(Matrix50);
Console.WriteLine();

Console.WriteLine("Введите координаты элемента массива");
int RowNumb = Convert.ToInt32(Console.ReadLine());
int ColumnNumb = Convert.ToInt32(Console.ReadLine());
if (RowNumb > Matrix2.GetLength(0) - 1 || ColumnNumb > Matrix2.GetLength(1) - 1)
{
    Console.WriteLine("Loozer!!!");
}
else
{
    Console.WriteLine($"значение позиции {Matrix2[RowNumb, ColumnNumb]}");
}
Console.WriteLine();
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Задача 52. ");
Console.WriteLine("Среднее каждого столбца -");
ArithmeticMean(Matrix2);
Console.WriteLine();
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,25
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
Console.Write("Задайте row от 3 до 10 - \t\t");
//добавить проверку на размерность массива меньше ноля
int RowMass = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте column от 3 до 10 - \t\t");
//добавить проверку на размерность массива меньше ноля
int ColumnMass = Convert.ToInt32(Console.ReadLine());
//Console.Write("задайте диапазон значений массива. от 100 до 999 - \t");
//добавить проверку на отрицательное число или вставить еще строку ввода нижней границы диапазона
int ArrayValues = 10; //Convert.ToInt32(Console.ReadLine());


double[,] MassFloDogi = new double[RowMass, ColumnMass];
MassivDouble(MassFloDogi, ArrayValues);
PrintMassivDouble(MassFloDogi);

Console.WriteLine();