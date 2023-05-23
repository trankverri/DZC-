// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.WriteLine("Семинар 5.");

Console.Write("Задайте длину массива от 5 до 20 - \t\t");
//добавить проверку на размерность массива меньше ноля
int LenMass = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте диапазон значений массива. от 1 до 100 - \t");
//добавить проверку на отрицательное число или вставить еще строку ввода нижней границы диапазона
int ArrayValues = Convert.ToInt32(Console.ReadLine());


// new massiv
void Massiv(int[] mass, int num1, int num2)
{
    Random dice = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = dice.Next(-num2, num2);
    }
}
void PrintMassiv(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"[{mass[i]}] ");
    }
    Console.WriteLine();
}

int[] mass = new int[LenMass];
Massiv(mass, LenMass, ArrayValues);
Console.WriteLine("Исходный массив данных");
PrintMassiv(mass); Console.WriteLine();

Console.WriteLine(@"Задача 31: Найдите сумму отрицательных и положительных элементов массива.");

int SummNegative(int[] mass)
{
    int SummN = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < 0)
        {
            SummN = SummN + mass[i];
        }

    }
    return SummN;
}
int SummPozitive(int[] mass)
{
    int SummP = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            SummP = SummP + mass[i];
        }
    }
    return SummP;
}
int A = SummNegative(mass);
int B = SummPozitive(mass);
Console.WriteLine($"summa negativ = {A} summa pozitiv = {B}");
Console.WriteLine();



// Задача 32: 
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.WriteLine(@"Задача 32.положительные элементы замените на соответствующие
                    отрицательные, и наоборот");


void ReversNumber(int[] mass)
{
    int RevNumb = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            RevNumb = mass[i];
            mass[i] = -RevNumb;
        }
        else
        {
            RevNumb = mass[i];
            mass[i] = Math.Abs(RevNumb);
        }
    }
}
ReversNumber(mass);
Console.WriteLine("New массив данных");
PrintMassiv(mass);
Console.WriteLine();

// Задача 33: 
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет. 3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Задача 33. определяеm присутствует ли заданное число в массиве.\n");
Console.WriteLine("Задайте число для проверки в массиве.");
int NewNumber = Convert.ToInt32(Console.ReadLine());

int BimgNumber(int[] mass, int number2)
{
    int RevNumb = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == number2) 
        {
            RevNumb = RevNumb + 1;
        }
    }
    return RevNumb;
}
int D = BimgNumber(mass, NewNumber);
Console.WriteLine($"Цифра {NewNumber} содержится в массиве {D} раз");
Console.WriteLine();

// Задача 35: 
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5
Console.WriteLine(@"Задача 35.Найдите количество элементов массива, 
                    значения которых лежат в отрезке [10,99].");
//Console.Write("Задайте min границу диапазона проверки в массиве.");
int LowNumber = 10; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Задайте max границу диапазона проверки в массиве.");
int HiNumber = 99; //Convert.ToInt32(Console.ReadLine());

int NumberOfRecords(int[] mass, int LowNumber, int HiNumber)
{
    int NumberElements = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] >= LowNumber && mass[i] <= HiNumber) 
        {
            NumberElements = NumberElements + 1;
        }
    }
    return NumberElements;
}
int Digits = NumberOfRecords(mass, LowNumber, HiNumber);
Console.WriteLine($"Элементов массива в диапазоне [{LowNumber} - {HiNumber}] в массиве содержится {Digits} раз");
Console.WriteLine();



// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21
Console.Write(@"Задача 37. Найдите произведение пар чисел в одномерном массиве
                           Результат запишите в новом массиве.\n");
//Console.Write("Задайте длину массива от 5 до 10 - \t\t");
//добавить проверку на размерность массива меньше ноля
int LenMass2 = 10; //Convert.ToInt32(Console.ReadLine());
Console.Write("задайте диапазон значений массива. от 1 до 10 - \t");
//добавить проверку на отрицательное число или вставить еще строку ввода нижней границы диапазона
int ArrayValues2 = 10; //Convert.ToInt32(Console.ReadLine());

void MassivDigits(int[] mass)
{
    int x = mass.Length;
    int y = 0;
    if (x % 2 == 0)
    {
        y = x / 2;
    }
    else
    {
        y = x / 2 + 1;
    }
    int[] massD = new int[y];
    for (int i = 0; i < y; i++)
    {
        if (i == (x-1))
        {
            massD[i] = mass[i];
        }
        else
        {
            massD[i] = mass[i] * mass[x - 1];
        }
        x--;
        Console.Write($" [{massD[i]}]");
    }
}

int[] mass2 = new int[LenMass2];
Massiv(mass2, LenMass2, ArrayValues2);
Console.WriteLine("Исходный массив ");
PrintMassiv(mass2); Console.WriteLine();
MassivDigits(mass2);
Console.WriteLine();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Задачи 34, 36\n");
//Console.Write("Задайте длину массива от 5 до 10 - \t\t");
//добавить проверку на размерность массива меньше ноля
int LenMass34 = 10; //Convert.ToInt32(Console.ReadLine());
//Console.Write("задайте диапазон значений массива. от 100 до 999 - \t");
//добавить проверку на отрицательное число или вставить еще строку ввода нижней границы диапазона
int ArrayValues34 = 999; //Convert.ToInt32(Console.ReadLine());

int EvenValues(int[] mass)
{
    int NumberElements = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            NumberElements = NumberElements + 1;
        }
    }
    return NumberElements;
}
// odd value positions
int SummOddPosition (int[] mass)
{
    int SummElements = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 == 0)
        {
            SummElements = SummElements + mass[i];
        }
    }
    return SummElements;
}
// 
int[] mass34 = new int[LenMass34];
Massiv(mass34, LenMass34, ArrayValues34);
Console.WriteLine("Исходный массив ");
PrintMassiv(mass34); Console.WriteLine();
int Digi = EvenValues(mass34);
Console.WriteLine($"Задача 34. Четных элементов в массиве {Digi}.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//Console.WriteLine("Задача 36.Найдите сумму элементов, стоящих на нечётных позициях\n");

int SummDigi = SummOddPosition(mass34);
Console.WriteLine($"Задача 36. Сумма элементов массива с нечетным индексом = {SummDigi}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Задача 38.Найдите разницу между максимальным и минимальным элементов массива\n");
//Console.Write("Задайте длину массива от 5 до 10 - \t\t");
//добавить проверку на размерность массива меньше ноля
int LenMass38 = 10; //Convert.ToInt32(Console.ReadLine());
//Console.Write("задайте диапазон значений массива. от 100 до 999 - \t");
//добавить проверку на отрицательное число или вставить еще строку ввода нижней границы диапазона
int ArrayValues38 = 100; //Convert.ToInt32(Console.ReadLine());

// Заполнение массива double
void MassivDouble(double[] mass, int num1, int num2)
{
    Random dice = new Random();
    for (int i = 0; i < num1; i++)
    {
        mass[i] = dice.Next(num1, num2) + dice.NextDouble();
    }
}
void PrintMassiv38(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"[{mass[i]:f2}] ");
    }
    Console.WriteLine();
}
//разница между мах и мин значениями массива
double  MaxMin(double[] mass)
{
    double Max = 0;
    double Min = 0;
    double MaxMin = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > Max)
        {
            Max = mass[i];
        }
        if (mass[i] < Min)
        {
            Min = mass[i];
        }
    }
    MaxMin = Max - Min;
    Console.WriteLine();
    return MaxMin;
}

//
double[] MassFloDogi = new double[LenMass38];
MassivDouble(MassFloDogi, LenMass38, ArrayValues38);
PrintMassiv38(MassFloDogi);
double Z = MaxMin(MassFloDogi);
Console.WriteLine($"Разница между Max и Min = {Z:f2} \n");
Console.WriteLine("ДЗ ВСЕ\n");
