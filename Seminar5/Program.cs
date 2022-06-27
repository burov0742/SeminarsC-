// необходимо создать массив из 12 случайных чисел от -9 до 9. Далее найти сумму положительных элементов и сумму отрицательных элементов
/*
int[] CreatorRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();
    return newArray;
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }

    return sum;
}

int FindNegativeSum(int[] array)

{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }

    return sum;
}

int[] myArray = CreatorRandomArray(12,-9,9);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));

*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CreatorRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();
    return newArray;
}

int[] ChangePositiveToNegative (int[] array)
{   

    for (int i = 0; i < array.Length; i ++)
    {
        array [i] *= -1;
        Console.Write(array[i] + " ");
    }
   

    return array;
}

int[] myArray = CreatorRandomArray(10, -10, 10);

Console.WriteLine(ChangePositiveToNegative(myArray));

*/

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*
int[] CreatorRandomArray(int size, int min, int max)

{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();
    return newArray;
}

bool FindNumInArray (int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
        
    }
    return false;
}

Console.Write("Imput num a: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatorRandomArray(10,-10,10);

Console.WriteLine(FindNumInArray(newArray, a));

*/

// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreatorRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();
    return newArray;
}

int FindNumInRage (int [] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    int sum = 0;
    {
        if (array[i] > min && array[i] < max) sum++;
    }

    return sum;
}

int min = 10;
int max = 99;

int [] newArray = CreatorRandomArray(10,-10,10);

Console.WriteLine(FindNumInRage(newArray,min,max));