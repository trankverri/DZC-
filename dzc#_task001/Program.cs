// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2.");
Console.WriteLine("Напишите программу, которая принимает два числа и выдает");
Console.WriteLine("какое число больше а какое меньше.");
// Ввод данных по задаче
Console.WriteLine("Введите двухзначное число от 10 до 99.");
// введите двухзначное число. это будет как длина массива
// так и граница дипазона для Random().Next (1, num);
// конвертируем полученное строковое значение в целое число
int num = Convert.ToInt32(Console.ReadLine()); 
// задаем число А
int numberA = new Random().Next(1, 100); // 1 2 3 4 ... 9
// Пишем на экране 
Console.WriteLine("Число А " + numberA);
// задаем число В
int numberB = new Random().Next(1, 100);
// Пишем на экране
Console.WriteLine("Число В " + numberB);

// Решаем задачу 2.
if (numberA>numberB)
{
    Console.WriteLine("Число А больше");
}
else
{
   Console.WriteLine("Число B больше");
}
int result = numberA + numberB;
Console.WriteLine("Sum A+B " + result);