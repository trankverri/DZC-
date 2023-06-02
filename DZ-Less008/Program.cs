// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Урок 8. Двумерные массивы. Продолжение");
void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 9);
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
void PrintArray56(int[,] mass)
{
    int S = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]}\t");
            S += mass[i, j];
        }
        Console.Write("IndexRow = {0}, SummRow = {1}\t", i, S);
        Console.WriteLine();
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Метод сортировки строк
void SortRowMassiva(int[,] mass)
{
    int[] Temp = new int[mass.GetLength(1)];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Temp[j] = mass[i, j];
        }
        ShellSort(Temp);
        //Array.Sort(Temp);
        Array.Reverse(Temp);
        for (int k = 0; k < mass.GetLength(1); k++)
        {
            mass[i, k] = Temp[k];
        }

    }
}
// Метод сортировки колонок
void SortColumnMassiva(int[,] mass)
{
    int[] Temp = new int[mass.GetLength(0)];

    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            Temp[i] = mass[i, j];
        }
        //ShellSort(Temp);
        Array.Sort(Temp);
        Array.Reverse(Temp);
        for (int k = 0; k < mass.GetLength(0); k++)
        {
            mass[k, j] = Temp[k];
        }
    }
}


// честно слизанный кусок кода с реализацией сортировки Shellа (для развития)
//метод для обмена элементов
static void Swap(ref int a, ref int b)
{
    var t = a;
    a = b;
    b = t;
}
static int[] ShellSort(int[] array)
{
    //расстояние между элементами, которые сравниваются
    var d = array.Length / 2;
    while (d >= 1)
    {
        for (var i = d; i < array.Length; i++)
        {
            var j = i;
            while ((j >= d) && (array[j - d] > array[j]))
            {
                Swap(ref array[j], ref array[j - d]);
                j = j - d;
            }
        }
        d = d / 2;
    }
    return array;
}
// конец кода сортировки Шелла

//основное тело кода

// //Console.Write("Задайте число строк от 3 до 10 - \t\t");
// int A = 4; //Convert.ToInt32(Console.ReadLine());
// //Console.Write("Задайте число колонок от 3 до 10 - \t\t");
// int B = 4; //Convert.ToInt32(Console.ReadLine());
// int[,] Matrix2 = new int[A, B];

// FillArray(Matrix2);
// PrintArray(Matrix2);
// Console.WriteLine();
// Console.WriteLine("Задача 54");
// SortRowMassiva(Matrix2);
// PrintArray(Matrix2);
// Console.WriteLine();
// SortColumnMassiva(Matrix2);
// PrintArray(Matrix2);

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Задача 56");
int RowMinSumm(int[,] mass)
{
    int[] Temp = new int[mass.GetLength(1)];
    int Summ = 0;
    int MinSumm = 0;
    int IndRow = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Summ += mass[i, j];
        }
        if (MinSumm > Summ)
        {
            Summ = MinSumm;
            IndRow = i;
        }

    }
    return IndRow;
}

//Console.Write("Задайте число строк от 3 до 10 - \t\t");
int RowMass2 = 4; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Задайте число колонок от 3 до 10 - \t\t");
int ColumnMass2 = 4; //Convert.ToInt32(Console.ReadLine());
int[,] Matrix56 = new int[RowMass2, ColumnMass2];
FillArray(Matrix56);
PrintArray56(Matrix56);
Console.WriteLine("Number row MinSumm = {0}", RowMinSumm(Matrix56));


/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Задача 58");
//Console.Write("Задайте число строк от 3 до 10 - \t\t");
int RowMass58 = 3; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Задайте число колонок от 3 до 10 - \t\t");
int ColumnMass58 = 3; //Convert.ToInt32(Console.ReadLine());
int[,] Matrix58 = new int[RowMass58, ColumnMass58];
int[,] Matrix59 = new int[RowMass58, ColumnMass58];

//вывод 2х массивов
void PrintArray58(int[,] mass, int[,] mass2)
{
    int S = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]}\t");
            S += mass[i, j];
        }
        Console.Write($"|\t");
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            Console.Write($"{mass2[i, j]}\t");
            S += mass[i, j];
        }
        Console.WriteLine();
    }
}
// Умножение массивов
int[,] Task58(int[,] mass, int[,] mass2)
{
    //проверка равенства количества строк и столбцов матриц
    int A = mass.GetLength(0);
    int B = mass2.GetLength(1);
    // if (A != B)
    // {
    //     Console.WriteLine("матрицы нельза перемножить");

    // }
    int[,] TempMass = new int[A, B];

    for (int i = 0; i < A; i++)
    {
        for (int j = 0; j < B; j++)
        {
            for (int k = 0; k < A; k++)
            {
                TempMass[i, j] += mass[i, k] * mass2[k, j];

            }
            Console.Write("[ {0} ]", TempMass[i, j]);
        }
        Console.WriteLine();
    }
    return TempMass;
}

FillArray(Matrix58);
FillArray(Matrix59);
PrintArray58(Matrix58, Matrix59);
Task58(Matrix58, Matrix59);
Console.WriteLine();
//PrintArray();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задача 60");
void Fill3DArray(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] = new Random().Next(0, 9);
            }
        }

    }
}
void Print3DArray(int[,,] mass)
{
    for (int k = 0; k < mass.GetLength(2); k++)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Console.Write($"{mass[i, j, k]} ({i},{j},{k}])\t");
            }
        Console.WriteLine();    
        }
        
    }
}

int[,,] Matrix60 = new int[2, 2, 2];
Fill3DArray(Matrix60);
Print3DArray(Matrix60);
Console.WriteLine();

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/