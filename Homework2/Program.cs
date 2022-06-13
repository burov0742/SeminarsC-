// Задача №1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*

int FindSecondNum (int num)
{
    if (num > -999 && num < 999 &&  num != 0)
    {
    int des, SecondNum;

    des  = num % 100;
    SecondNum = des / 10;

    return SecondNum;
    }
    else 

    return -1;

}

int num,result;

Console.WriteLine("Imput three-digital number: ");
num = Convert.ToInt32(Console.ReadLine());

result = FindSecondNum(num);

if (result == -1) Console.WriteLine("Please imput correct number");
else Console.WriteLine($"The second number is {result}");

*/

// Задача №2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*

int FindThirdFigure(int num)

{
    int ThirdFigure;
    if (num > 99 ) 
    {
    while (num > 999)

        {
        num = num /10;
        }

        ThirdFigure = num % 10;
        return ThirdFigure;
    }
    else 
    
    return -1;
    
}

int num, result;
Console.WriteLine("Imput number: ");
num = Convert.ToInt32(Console.ReadLine());

result = FindThirdFigure(num);

if (result == -1) Console.WriteLine("Nuber has not third figure");
else Console.WriteLine($"Third figure of number is {result}");

*/

// Задача №3:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
string Weekend(int day)
{
    if (day > 0 && day <= 7)
    {
        if (day == 6 || day == 7) return ("This is a weekend");
        else return ("This is not weekend");
        
    }
    else return ("Please, imput correct current day of week");
}

int day;
Console.WriteLine("Imput current day of week: ");
day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(day));

*/