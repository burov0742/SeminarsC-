//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double [,] CreateTwoDivDoubleArray (int row, int colm, double min, double max)
{
    double [,] newArray = new double [row, colm];
    for (int i = 0; i < row; i ++)
        for (int j = 0; j < colm; j ++)
            newArray[i,j] = Math.Round(min + new  Random().NextDouble()*(max - min), 1);
        
    return newArray;
}

void ShowTwoDivArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input numbers of rows ");
int row  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input numbers of column ");
int colm  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min number of array ");
double min  = Convert.ToDouble(Console.ReadLine());

Console.Write("Input max number of array ");
double max  = Convert.ToDouble(Console.ReadLine());

double [,] twoDivArray = CreateTwoDivDoubleArray(row, colm, min, max);

ShowTwoDivArray(twoDivArray);

/*

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

/*
int [,] CreateRandomTwoDivArray (int row, int colm, int min, int max)
{
    int [,] newArray = new int [row,colm];
    for (int i = 0; i < row; i++)
        for ( int j = 0; j < colm; j ++)
            newArray[i,j] = new Random().Next(min, max +1);
    
    return newArray;
}

void ShowTwoDivArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindNumberInTwoDivArray (int a, int b)
{
    int [,] newMatrix = CreateRandomTwoDivArray(5,5,1,100); // использую заданный руками массивб т.к. нет противоречий с условиями задачи.
    ShowTwoDivArray(newMatrix);
    if (a  <= newMatrix.GetLength(0) && b <= newMatrix.GetLength(1)) 
        Console.WriteLine($"Number of this array is {newMatrix[a-1,b-1]}");
    else Console.WriteLine($"This array has not this element");
    
}

- не смог реализовать идею, когда пользователь задает сам массив. 
Не получилось решить ошибку (error CS7036: Отсутствует аргумент, соответствующий требуемому формальному парамет)
если я в 75 строке на прием в метод вписываю двумерный массив.

//Console.Write("Input numbers of rows ");
//int row  = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input numbers of columns ");
//int colm  = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input min number of array ");
//int min  = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input max number of array ");
//int max  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input find row ");
int a  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input find column ");
int b  = Convert.ToInt32(Console.ReadLine());

FindNumberInTwoDivArray(a,b);

*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int [,] CreateRandomTwoDivArray (int row, int colm, int min, int max)
{
    int [,] newArray = new int [row,colm];
    for (int i = 0; i < row; i++)
        for ( int j = 0; j < colm; j ++)
            newArray[i,j] = new Random().Next(min, max +1);
    
    return newArray;
}

void ShowTwoDivArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

string FindAverageArithmeticColumns (int [,] array)
{
    double sum = 0;
    double average = 0;
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum  += array[i,j];
            
        }
        average =  sum/array.GetLength(0);
        
        result = result + Math.Round(average,1) + " ";
        sum = 0;

    }
    Console.Write ("averages arithmetic of columns are " + result);
   return result;
}

Console.Write("Input numbers of rows ");
int row  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input numbers of columns ");
int colm  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min number of array ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max number of array ");
int max  = Convert.ToInt32(Console.ReadLine());

int [,] newMatrix = CreateRandomTwoDivArray(row, colm, min, max); 
ShowTwoDivArray(newMatrix);

FindAverageArithmeticColumns(newMatrix);

*/