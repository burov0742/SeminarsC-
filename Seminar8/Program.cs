// задать двумерный массив и поменять первую и последнюю строки

/*
int [,] CreateRandomTwoDimArray (int row, int colm, int min, int max)
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

int [,] ChangeLines (int [,] array, int strIndex1, int strIndex2)
{
    int temp;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

int [,] myArray = CreateRandomTwoDimArray(4, 5, 1, 9);
ShowTwoDivArray(myArray);

myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);
Console.WriteLine();
ShowTwoDivArray(myArray);
*/

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int [,] CreateRandomTwoDimArray (int row, int colm, int min, int max)
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

int [,] ChangeRowsOnColumns (int [,] array)
{
    int temp;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i+1; j < array.GetLength(1); j++)
            {
                
                temp = array [i,j];
                array [i, j] = array [j, i];
                array [j, i] = temp;
                
                
            }
        }
    }
    else Console.WriteLine("Uncorrect array");

    return array;
}

int [,] myArray = CreateRandomTwoDimArray(5, 5, 1, 9);
ShowTwoDivArray(myArray);

myArray = ChangeRowsOnColumns(myArray);
Console.WriteLine();
ShowTwoDivArray(myArray);
*/

//Из двумерного массива целых чисел удалить (заменить на 0) строку и столбец, на пересечении которых расположен наименьший элемент.

/*
int [,] CreateRandomTwoDimArray (int row, int colm, int min, int max)
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

int [,] FindMinNumber (int [,] array)
{
    int min = array[0,0];
    int row = 0;
    int colm = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            if ( min > array[i,j]) 
            {
                min = array[i,j];
                row = i;
                colm = j;
                
            }
            
        }
        
    }
    Console.WriteLine ("Min number is " + min + " column is "  + colm +  " row is " + row);
    Console.WriteLine ();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i,colm] = 0;
    }
    for (int j =0; j < array.GetLength(1); j++)
        array[row, j] = 0;
    
    return array;
}

int [,] myArray = CreateRandomTwoDimArray( 5, 5, 1, 9);
ShowTwoDivArray(myArray);
Console.WriteLine();

myArray = FindMinNumber (myArray);
ShowTwoDivArray(myArray);

*/