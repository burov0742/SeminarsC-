// Задача №1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* Первый вариант решения задачи.

bool PalindromNum(int num)
{
    
     int a, b, c, d;
     a = num / 10000;
     b = (num / 1000) % 10;
     c = (num % 100) / 10;
    d = num % 10;

    if (a == d && b == c) return true;
    else return false;

}
int num;
Console.Write("Please, input 5-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if (PalindromNum(num)) Console.WriteLine($"{num} is a palindrome number");
    else Console.WriteLine($"{num} is not palindrome number");
}
else Console.WriteLine("Please, input the correct number");

*/

/* Второй вариант решения задачи.

void PalindromNum(int num)
{
    if (num > 9999 && num < 100000)
    {
        int a, b, c, d;
        a = num / 10000;
        b = (num / 1000) % 10;
        c = (num % 100) / 10;
        d = num % 10;

        if (a == d && b == c) Console.WriteLine($"{num} is a palindrome number");
        else Console.WriteLine($"{num} is not palindrome number");
    }
    else Console.WriteLine("Please, input the correct number");
}
int num;
Console.Write("Please, input 5-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

PalindromNum(num);

*/

// Задача №2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*

double FindLenght(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    return Math.Sqrt (Math.Pow((Xb - Xa),2) + Math.Pow((Yb - Ya),2) + Math.Pow((Zb - Za),2));
}

double Xa, Ya, Za, Xb, Yb, Zb, Lenght;

Console.Write("Please, input Xa coordinate: ");
Xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input Ya coordinate: ");
Ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input Za coordinate: ");
Za = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input Xb coordinate: ");
Xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input Yb coordinate: ");
Yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input Zb coordinate: ");
Zb = Convert.ToInt32(Console.ReadLine());

Lenght = FindLenght(Xa, Ya, Za, Xb, Yb, Zb);

Console.Write($"The length between two points is {Lenght}");

*/

/*

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNum (double num)
{
    double current, Cube;
    current = 1;

    while (current <= num)
    {
        Cube = Math.Pow(current,3);
        current ++;
        Console.Write(Cube + " ");
    }

}

double num;
Console.Write("Please, input number: ");
num = Convert.ToInt32(Console.ReadLine());

CubeNum (num);

*/
