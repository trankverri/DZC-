// See https://aka.ms/new-console-template numberor more innumberormation
Console.Clear();
Console.WriteLine("Задачи 25, 27, 29");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Задача 25");
Console.WriteLine($"введите 2 числа x и y");
int x, y;
Console.Write("x=");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("y=");
y = Convert.ToInt32(Console.ReadLine());

double NatStep(int num1, int num2)
{
    double num = Math.Pow(num1,num2);
    return num;
}
double NumRes = NatStep(x,y);

Console.WriteLine(NumRes);
Console.WriteLine("Press Enter key to continue");
Console.ReadLine();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Задача 27");
Console.WriteLine($"введите число от -999 999 999 до 999 999 999");
int num = Convert.ToInt32(Console.ReadLine());
int SoomNum (int number)
{
    int Summa = 0;
    string str = number.ToString(); // конвертируем число в строку 
    int[] b = new int[str.Length];  //создаем новый массив
    for( int i=0; i< str.Length; i++) //заполняем новый массив и суммируем
    {
        b[i] = int.Parse(str[i].ToString());
        Summa = Summa + b[i];
    }
    return Summa;
}

int Num2 = SoomNum(num);
Console.WriteLine(Num2);
Console.WriteLine("Press Enter key to continue");
Console.ReadLine();

Console.WriteLine("Задача 27 вариант 2");
Console.WriteLine($"введите число от -999 999 999 999 999 до 999 999 999 999 999");
Int64 num1 = Convert.ToInt64(Console.ReadLine());
Int64 SoomNum1(Int64 number)
{
    Int64 Summa = 0;
    Int64 x = 0;
    Int64 R = Math.Abs(number);
    while (R > 0)
    {
        x = R % 10;
        Summa = Summa + x;
        R = R / 10;
    }
    return Summa;
}

Int64 Num3 = SoomNum1(num1);
Console.WriteLine(Num3);
Console.WriteLine("Press Enter key to continue");
Console.ReadLine();


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Задача 29");
Console.WriteLine("Введите число от 8 до 15");
int num3 = Convert.ToInt32(Console.ReadLine());
Random dice = new Random();
int[] mass = new int[num3];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = dice.Next(-100, 100);
    Console.Write($"[{mass[i]}] ");
}

Console.WriteLine("ДЗ всё");