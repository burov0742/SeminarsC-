//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


/*
int[] CreatorRandomArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();
    return newArray;
}

Console.Write("Imput size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatorRandomArray (size);

int FindCountEvenNum (int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }

    return count;
}

Console.WriteLine("Count even numbers in array is " + FindCountEvenNum(newArray));
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

Console.Write("Imput size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput min number in array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput max number in array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreatorRandomArray (size,min,max);

int SumOddIndexNumbers (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        
        sum +=array[i];
    }

    return sum;
}

Console.WriteLine("Sum of all numbers with odd index is " + SumOddIndexNumbers(newArray));
*/

//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] CreateRandomDoubleArrray (int size)
{
    double [] randomArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().NextDouble()*100;
        Console.Write(randomArray[i] + " ");
    }
    return randomArray;
}


Console.Write("Imput size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateRandomDoubleArrray (size);

double FindMaxNum(double[] array)
{
    double max = 0;

    for(int i = 0; i < array.Length; i++)

    if (array[i] > array[i+1]) 
    {
        max = array[i];
    }
    else 
    {
        max = array[i+1];
    }
    
    return max;
}

double maxNum = FindMaxNum(newArray);
Console.WriteLine($"Max is {maxNum}");