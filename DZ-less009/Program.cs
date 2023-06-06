// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Задайте N");
int N = Convert.ToInt32(Console.ReadLine());
void NaturalNumber(int Num)
{
    if (Num == 0) return;
    Console.Write($"{Num}, ");
    NaturalNumber(Num - 1);
}
NaturalNumber(N);
Console.WriteLine();
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте M");
int M = Convert.ToInt32(Console.ReadLine());
void NaturalNumberSumm(int num1, int num2)
{
    //int sum=0;
    if (num1 == 0 || num1==num2) return;
    //Console.Write($"{num1 + (num1+1)}, ");
    Console.WriteLine($"{num1} + {num1+1} = {num1 + (num1+1)}, ");
    NaturalNumberSumm(num1 + 1,num2);
}
NaturalNumberSumm(N,M);



// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//Непонятная функция.