// рпограмма ввводит все натуральные числа от 1 до N
/*()
void ShowNums (int n)
{
    if (n != 1)
        ShowNums(n - 1);

    Console.Write (n + " ");
}

Console.Write("Input ineger positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums (int n, int m)
{
    if (n != m)
        ShowNums(n - 1, m);

    Console.Write (n + " ");
}

Console.Write("Input ineger positive number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input ineger positive number: ");
int min = Convert.ToInt32(Console.ReadLine());

ShowNums(max, min);
*/

/*
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfNums (int num)
{
    
    if (num != 0)
       return num%10 + SumOfNums(num/10);
    
    return 0;
}

Console.Write("Input ineger positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine (SumOfNums(num));

*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

/*
int Stepen (int a, int b)
{
    if (b != 0)
    {
        return a*Stepen(a,b-1);
    }

    return 1;
}

Console.Write("Input ineger positive number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input ineger positive number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Stepen(a,b));

*/
