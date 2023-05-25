// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Семинар 6");

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
/*
void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1, 99);
        }

    }
}
/*
void ReversArray(int[,] mass)
{
    int rev = 0;
    int k= mass.GetLength(1);
    int z=mass.GetLength(0);
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1)/2; j++)
        {
            rev = mass[i, j];
            mass[i, j] = mass[z-i-1, k-j - 1];
            mass[z-i-1, k-j - 1] = rev;
        }

    }
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReversArray(matrix);
PrintArray(matrix);
*/
/*
int[,] Pict = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,1,1,1,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,1,1,1,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,1,1,1,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,1,1,1,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]}");
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (Pict[row, col] == 0)
    {
    Pict[row, col] = 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
    }
}

PrintImage(Pict);
FillImage(5, 10);
PrintImage(Pict);
*/
/*
double Fact(int n)
{
    if (n == 1) return 1;
    else return n * Fact(n - 1);
}
int G = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < G; i++)
{
    Console.WriteLine($"{i}! = {Fact(i)}");
}
*/
/*
double Fibonach(int n)
{
    if (n == 1 || n==2) return 1;
    else return Fibonach(n - 1) + Fibonach(n-2);
}
int G = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < G; i++)
{
    Console.WriteLine($"{i}! = {Fibonach(i)}");
}
*/

/*
int num;
Console.Write("Введите номер: ");
num = int.Parse(Console.ReadLine());
string rem = "";
while (num > 0)
{
    rem = (num % 2).ToString() + rem;
    num = num / 2;
}
Console.WriteLine($"Бинарный формат для заданного номера {rem}");
*/
/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3
Console.WriteLine("Задача 41");
var UserArray = new List<int>();
string a;

// do {
//     UserArray.Add = Convert.ToInt32(Console.ReadLine());
// } while (Console.ReadLine() != "W");
/*
            string buf;
            Console.WriteLine("Для окончания ввода дважды нажмите Enter");
            While (!string.IsNullOrEmpty((buf = Console.ReadLine()))){
                UserArray.Add(Convert.ToInt32(buf));
            }
            Console.WriteLine(string.Join(" ", UserArray));
            Console.ReadKey();
*/
/*
Console.WriteLine("Для окончания ввода введите Q");
Console.WriteLine("Введите новый элемент");
//Получаем строку и проверяем ее содержание
while (!string.IsNullOrEmpty((a = Console.ReadLine()))) //..((a = Console.ReadLine()) != "Q")
{
    UserArray.Add(Convert.ToInt32(a));
}
Console.Write("Введенный массив чисел: ");
Console.WriteLine(string.Join(" ", UserArray));
int[] UserMassiv = UserArray.ToArray();
Console.ReadKey();

int HiLow(int[] mass)
{
    int SummHi = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            SummHi = SummHi + 1;
        }
    }
    return SummHi;
}


int S = HiLow(UserMassiv);
Console.WriteLine($"Значний больше 0 ввели {S} раз");

/*
        void PrintMassiv(int[] mass){
            for (int i = 0; i < mass.Length; i++){
                Console.Write($"[{mass[i]}] ");
            }
        }
        PrintMassiv(UserMassiv); Console.WriteLine();
*/
/*
Console.Write("Для продолжения нажмите Enter");
Console.ReadKey();
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//Console.WriteLine("Задача 43");

void FillMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.WriteLine($"введите элемент {i},{j}");
            mass[i, j] = Convert.ToInt32(Console.ReadLine());
        }

    }
}
int[,] Matrix2 = new int[2, 2];
FillMatrix(Matrix2);
PrintArray(Matrix2);

int b1 = Matrix2[0, 1];
int b2 = Matrix2[1, 1];
int k1 = Matrix2[0, 0];
int k2 = Matrix2[1, 0];
double y, x, y2;
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1
x = (b2 - b1) / (k1 - k2);
//y = k1 * x + b1, y = k2 * x + b2;
y = k1 * x + b1;
y2 = k2 * x + b2;// странно

Console.WriteLine($" X =  {x:F2} | Y = {y:F2} Z= {y2:F2}");

for (int i = -10; i < 10; i++)
{
    y = k1 * i + b1;
    y2 = k2 * i + b2;
    Console.WriteLine($" X =  {i:F2} | Y = {y:F2} Z= {y2:F2}");
}
