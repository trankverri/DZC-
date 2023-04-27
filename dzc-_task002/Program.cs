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
Console.WriteLine($"Задача 10.");
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
// string str = 1337.ToString();
// Console.WriteLine(str[1]);
Console.WriteLine($"Задача 13.");
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
        Console.WriteLine($"Третье число - {R}");


    }
    else Console.WriteLine($"разрядность числа меньше 3х");
}

// Console.WriteLine("Press Enter key to continue");
// Console.ReadLine();

// int y = (F%100) / 10;
// Console.WriteLine(y);


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine($"Задача 15.");
Console.WriteLine($"введите число от 1 до 7");
while (true)
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0 && a < 8)
    {
        if ( a==6 || a==7 ) { 
            Console.WriteLine("Nirvana");
        }
        else 
        {
            Console.WriteLine("Arbaiten!");
        }
    }
    else
    {
        Console.WriteLine("FasePalm");
        continue;
    }
}