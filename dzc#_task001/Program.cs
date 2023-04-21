// See https://aka.ms/new-console-template for more information

// Ввод данных по задаче
Console.WriteLine("Введите двухзначное число от 10 до 50.");
// введите двухзначное число. это будет как длина массива
// так и граница дипазона для Random().Next (1, num);
// конвертируем полученное строковое значение в целое число
int num = Convert.ToInt32(Console.ReadLine());
//Здесь можно было вставить проверку на
// if (num < 10 && num > 50 )
// {
//     Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
//     goto 
// }


// задаем число А, B, C
Random dice = new Random();
int numberA = dice.Next(num); // 0, 1, 2 3 4 ... num
int numberB = dice.Next(num);
int numberC = dice.Next(num);
// Пишем на экране 
Console.Write($"Число А = {numberA}, ");
Console.Write($"Число В = {numberB}, ");
Console.Write($"Число C = {numberC}");
Console.WriteLine();

// Решаем задачу 2.
Console.WriteLine("Задача 2. какое число больше А или В");

if (numberA > numberB)
{
    Console.WriteLine("Число А больше");
}
else
{
    Console.WriteLine("Число B больше");
}
int result = numberA + numberB;
Console.WriteLine("Sum A+B " + result);
Console.WriteLine();

// Решаем задачу 4.
Console.WriteLine("Задача 4. Какое число максимальное из трех.");

int largerValue;
largerValue = Math.Max(numberA, numberB);
largerValue = Math.Max(largerValue, numberC);
Console.WriteLine($"Max number = {largerValue}");
Console.WriteLine();

// Решаем задачу 6.
Console.WriteLine("Задача 6. Четное не четное.");
// Console.WriteLine($"numberA %2 {numberA %2}");
if (numberA % 2 > 0)
{
    Console.Write(" Число А нечетное,");
}
else
{
    Console.Write(" Число А четное,");
}
if (numberB % 2 > 0)
{
    Console.Write(" Число В нечетное,");
}
else
{
    Console.Write(" Число В четное,");
}

// Console.WriteLine($"numberC %2 {numberC %2}");
if (numberC % 2 > 0)
{
    Console.Write(" Число С нечетное,");
}
else
{
    Console.Write(" Число С четное,");
}

Console.WriteLine();

// задача 8
// напишите программу на входе число N, а на выходе показывает все четные от 1 до N.
Console.WriteLine("Задача 8. Четные числа массива.");

int[] mass = new int[num];
for (int i = 0; i < num; i++)
{
    mass[i] = dice.Next(num);
    Console.Write($" {mass[i]} ");
}
Console.WriteLine();
Console.WriteLine("печатаем четные числа");
for (int i = 0; i < num - 1; i++)
{
    if (mass[i] % 2 == 0)
    {
        Console.Write($" {mass[i]},");
    }

}

// while (index < num)
// {
//     

// }
