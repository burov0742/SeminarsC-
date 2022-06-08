
// Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*

int num1, num2;

Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
Console.WriteLine("Первое число больше второго");
}
else 
{
    Console.WriteLine("Второе число больше первого");

}

*/

//Напишите программу, которая принимает на ход три числа и выдаёт максимальное из этих чисел.

/*

int num1, num2, num3;

Console.Write("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
num3 = Convert.ToInt32(Console.ReadLine());


if (num1>num2)
{
    if (num1>num3)
    {
        if (num2<num3)
        {
            Console.WriteLine("Число " + num1 + " самое большое, а число " + num2 + " самое меньшее");
        }
        else
        {
            Console.WriteLine("Число " + num1 + " самое большое, а число " + num3 + " самое меньшее");
        }
    }
    else
    {
        Console.WriteLine("Число " + num3 + " самое большое, а число " + num2 + " самое меньшее");
    }
}
else
{   
    
    if (num1<num3)
        
    {
        if (num2>num3)
        {
        Console.WriteLine("Число " + num2 + " самое большое, а число " + num1 + " самое меньшее");
        }
        
        else
        {
        Console.WriteLine("Число " + num3 + " самое большое, а число " + num1 + " самое меньшее");
        }
    }
        
}
*/ 

/*
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num1;

Console.Write("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

*/

/*
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num1;

Console.Write("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current<num1)
{
    Console.Write(current + " ");
    current = current + 2;
}

*/