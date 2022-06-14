// Задача №1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
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
Console.Write("Please, imput 5-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if (PalindromNum(num)) Console.WriteLine($"{num} is a palindrome number");
    else Console.WriteLine($"{num} is not palindrome number");
}
else Console.WriteLine("Please, imput the correct number");

*/

// Задача №2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




