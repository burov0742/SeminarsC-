/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumInegerNum (int m, int n)
{
    if (n != m)
    {
        return SumInegerNum(m, n-1) + n +1;
    }
    return 0;
}

Console.Write("Input ineger positive number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input ineger positive number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (SumInegerNum(m,n));
*/

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
453 -> 3
45 -> 2
*/

/*
int AmountNums (int num)
{
    if (num !=0 ) 
    {
        
        return 1 + AmountNums(num/10);

    }
    return 0;
}

Console.Write("Input ineger positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (AmountNums(num));
*/