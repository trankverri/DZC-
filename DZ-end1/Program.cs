// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, препод.!");

// обявляем строковый массив


void Metod1(string [] StringArray)
{

    string[] TempArray= {""};

    foreach (var item in StringArray)
    {
        if (item.Length<=3)
        {
            TempArray=TempArray.Append(item).ToArray();
            Console.Write("{0}\t", item);
        }    
    }
}
// foreach (var item in TempArray)
// {
//     Console.Write("{0}\t", item);
// }
//}
string[] AR = {"Маi","Даша","М","Дарья","hre","00","qwert","qwe"};
Metod1(AR);
