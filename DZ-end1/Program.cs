// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, препод.!");

// обявляем строковый массив
string[] AR = {"Маша","Даша","Мария","Дарья","Катя"};

string Metod1(string[])
{
   int index=0;
   string[] Temperatur= {};
   string Text ="";
while (index<Metod1.Length)
{
    if (AR[index].Length<=0)
    {
        Text= AR[index];
        Temperatur.add(Text);
    }
    Console.Write("{Temperatur}\t");
}
}