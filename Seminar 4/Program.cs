// Написать  программу, которая складвает все цифры числа

/*
int FindSumDigits (int num)
{
    int sum = 0
    while ( num > 0 )
    {
        sum = sum + num % 10; // - краткая запись sum += nun % 10; "+=" - увеличить на, противоположный вариант "-="
        num = num / 10; // num /= 10 - скоратить переменную в N раз. Противоположно "*=" - увеличить переменную.
    }

    return sum;
}
*/

// принимает число и выдает сумму чисел от 1 до него

/*
int FindSum(int num)
{
    int sum = 0;
    int count = 1; 
    while (count <= num)
    {
        sum += count;
        count ++;
    }

    return sum;
}


Console.Write ("Imput number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = FindSum(num);
Console.WriteLine ($"Sum is {result}");

*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int FindMult(int num)
{
    int mult = 1;
    int count = 1; 
    while (count <= num)
    {
        mult *= count;
        count ++;
    }

    return mult;
}


Console.Write ("Imput number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = FindMult(num);
Console.WriteLine ($"Factoril is {result}");

*/

// Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.

/*
int Number(int num)
{
    int count = 0;
    if (num < 0)
        num *= -1;
        
    while (num >= 0)
        {
            num /= 10;
            count ++;
        }
    
    return count;
}

Console.Write ("Imput number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = Number(num);
Console.WriteLine ($"Number is {result}");

*/

// напишите программу которая зполнит массив 0 и 1 в случайном порядке

/*
int size = 8;
int [] RandomNumbers = new int [size];

for (int i = 0; i < size; i ++) // первое значние Индекса (счетчика), второе - условие при котором работает цикл, третье - шаг счетчика.
{
    RandomNumbers[i] = new Random().Next(0,2); // метод Next дает случайное значние в диапозоне, где первое значние - начало диапозона (включительно), второе - конец (невключительно). 
                                               // Пример: буду даны значние от 0 до 1.
    
}

for (int i = 0; i < size; i++)
{
    Console.Write(RandomNumbers[i] + " "); 
}
*/