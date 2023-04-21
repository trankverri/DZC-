// See https://aka.ms/new-console-template for more information

// Ввод данных по задаче
Console.WriteLine("Введите двухзначное число от 10 до 99.");
// введите двухзначное число. это будет как длина массива
// так и граница дипазона для Random().Next (1, num);
// конвертируем полученное строковое значение в целое число
int num = Convert.ToInt32(Console.ReadLine()); 
// задаем число А, B, C
Random dice = new Random();
int numberA = dice.Next(100); // 0, 1, 2 3 4 ... 100
int numberB = dice.Next(100);
int numberC = dice.Next(100);
// Пишем на экране 
Console.Write($"Число А = {numberA}, ");
Console.Write($"Число В = {numberB}, ");
Console.Write($"Число C = {numberC}");
Console.WriteLine();

// // Решаем задачу 2.
// Console.WriteLine("Задача 2. какое число больше А или В");

// if (numberA>numberB)
// {
//     Console.WriteLine("Число А больше");
// }
// else
// {
//    Console.WriteLine("Число B больше");
// }
// int result = numberA + numberB;
// Console.WriteLine("Sum A+B " + result);
// Console.WriteLine();

// // Решаем задачу 4.
// Console.WriteLine("Задача 4. Какое число максимальное из трех.");

// int largerValue;
// largerValue = Math.Max(numberA, numberB);
// largerValue = Math.Max(largerValue, numberC);
// Console.WriteLine($"Max number = {largerValue}");
// Console.WriteLine();

// // Решаем задачу 6.
// Console.WriteLine("Задача 6. Четное не четное.");
// // Console.WriteLine($"numberA %2 {numberA %2}");
// if ( numberA %2 == 0 ) 
// {
//     if ( numberA %2 > 0 ) 
//     {
//     Console.Write(numberA + " Число А нечетное");
//     }
//     else
//     {
//     Console.Write(numberA + " Число А четное");
//     }
// }
// if ( numberC %2 == 0 ) 
// {
//     if ( numberC %2 > 0 ) 
//     {
//     Console.Write($"{numberC} Число С нечетное");
//     }
//     else
//     {
//     Console.Write($"{numberC} Число С четное");
//     }
// }
// if ( numberB %2 == 0 ) 
// {
//     if ( numberB %2 > 0 ) 
//     {
//     Console.Write(numberB + " Число В нечетное");
//     }
//     else
//     {
//     Console.Write(numberB + " Число В четное");
//     }
// }

// задача 8
// напишите программу на входе число N, а на выходе показывает все четные от 1 до N.
Console.WriteLine("Задача 8. Четные числа массива.");
int index = 0;
int[] mass = new int[num];
// mass[0] = numberA;
// mass[1] = numberB;
// mass[2] = numberC;
while (index < num)
{
    mass[index]= new Random().Next(num);
    Console.Write($" {mass[inmex]} ");
}
