// See https://aka.ms/new-console-template for more information
// Проверка на кратность числа А к числу В
// Console.WriteLine("введите числа А и В");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int result = a % b;

// if (result == 0){
// Console.WriteLine("Yes!");
// }
// Console.WriteLine($"Nooo! {result}");



// int F = new Random().NeFt(100,1000);
// Console.WriteLine(F);
// int F1=F/100;
// int F2=F%100;
// int result = F1*10+F2;
// Console.WriteLine(@"{F1}{F2}");
// Console.WriteLine(result);

// // 
// Console.WriteLine("введите числа А и В");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (Math.Pow(a,2)==b || Math.Pow(b,2)==a){
//     Console.WriteLine("Yahoo!");
// } else Console.WriteLine("Noooo!");

// выводит сумму только положительных чисел
// Console.WriteLine("inrut ");
// int[] F = new int[3];
// int sum=0;

// for (int i=0; i<3; i++)
// {
//     F[i]= Convert.ToInt32(Console.ReadLine());
// }

// for (int i=0; i<3; i++)
// {
//     if (F[i] > 0){
//         sum += F[i];
//     }
// }
// Console.WriteLine(sum);

Console.Clear();
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine($"Задача 10. на выходе показывает вторую цифру этого числа");
int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int y = (x % 100) / 10;
Console.WriteLine(y);



/*
Задача 13: Напишите программу, которая выводит третью цифру заданного
 числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Задача 13. программа, которая выводит третью цифру заданного");
Console.WriteLine("числа или сообщает, что третьей цифры нет.");
int F = new Random().Next(-100, 1000);
Console.WriteLine(F);
int i = 0;
int k = F;
if (F < 0) F = -F;
{
    while (F > 0)
    {
        F = F / 10;
        i += 1;
    }
    Console.WriteLine($"Количество разрядов {i}");
    // int j = i;
    if (i > 2)
    {
        // int z = 1;
        // while (i > 1)
        // {
        //     z = z * 10;
        //     i -= 1;
        // }
        // Console.WriteLine($"z= {z}");
        // Console.WriteLine($"i= {i}");
        // Console.WriteLine($"j= {j}");

        // while (j > k)
        // {
        //     y = F / 10;
        //     Console.WriteLine($"y= {y}");
        //     j -= 1;
        // }
        int R = k % 10;
        Console.WriteLine($"Третье число - " + R);
    }
    else Console.WriteLine($"разрядность числа меньше 3х");
}

Console.WriteLine("Press Enter key to continue");
Console.ReadLine();

// int y = (F%100) / 10;
// Console.WriteLine(y);


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Задача 15.");
Console.WriteLine("программа, которая принимает на вход цифру, обозначающую день недели,");
Console.WriteLine("и проверяет, является ли этот день выходным");
Console.WriteLine($"введите число от 1 до 7");
while (true)
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0 && a < 8)
    {
        if (a == 6 || a == 7)
        {
            Console.WriteLine("Nirvana");
            break;
        }
        else
        {
            Console.WriteLine("Arbaiten!");
        }
    }
    else
    {
        Console.WriteLine("FasePalm");
        //continue;
        break;
    }
}
Console.WriteLine("идем дальше");
Console.WriteLine("Press Enter key to continue");
Console.ReadLine();

// Задача 19. Проверьте пятизначное число на полиндром.
Console.WriteLine($"Задача 19. Проверка на полиндром");
Console.WriteLine($"введите число. максимум 10 знаков");

int num = Convert.ToInt32(Console.ReadLine());

// `n` сохраняет заданное целое число
int n = num;
// `rev` хранит обратную сторону заданного целого числа
int rev = 0;

while (n>0)
{
    // это сохранит последнюю цифру `n` в переменной `r`
    // например, если `n` равно 1234, то `r` будет равно 4
    int r = n % 10;
    //Console.WriteLine("r " + r);

    // добавляем `r` к `rev` вместо себя
    // например, если `rev = 65` и `r = 4`, то новый `rev` будет 654
    rev = rev * 10 + r;

    // удалить последнюю цифру из `n`
    // например, если `n` равно 1234, то новое `n` будет 123
    n = n / 10;
    //Console.WriteLine("n " + n);
}
Console.WriteLine(rev);
if (num == rev)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}
Console.WriteLine("Press Enter key to continue");
Console.ReadLine();

// Задача 21. Длина отрезка по координатам.
// Console.WriteLine($"Задача 21. Длина отрезка по координатам.");
// variant 1

Console.WriteLine($"введите координаты");
int x1, y1, z1, x2, y2, z2;
Console.Write("x1=");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1=");
z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2=");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2=");
z2 = Convert.ToInt32(Console.ReadLine());

double Line = Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 0.5);
Console.WriteLine("Line =" + Math.Round(Line, 2));
Console.WriteLine("_");

// //Variant 2
// Console.WriteLine($"введите координаты");

// int [,]  Points = new int [,3];


// Задача 23. Вход N. Выход таблица кубов чисел от 1 до N
Console.WriteLine("Задача 23. таблица кубов чисел от 1 до N");
Console.WriteLine("введите число");
int numbr = Convert.ToInt32(Console.ReadLine());
double [] kub = new double [numbr];

for (int o = 0; o < numbr; o++)
{
    kub[o] = Math.Pow((o+1), 3);
}
Console.WriteLine("Print new array.");
int v = 0;
while (v < numbr)
{
    Console.Write("| " + kub[v]);
    v++;
}
