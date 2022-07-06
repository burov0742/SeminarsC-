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
    {
        for (int j = 0; j < colm; j ++)
        {
            newArray[i,j] = Math.Round(min + new  Random().NextDouble()*(max - min), 1);
        }
        
    }
    return newArray;
}

void ShowTwoDivArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i,j] + " ");
        }
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

*/