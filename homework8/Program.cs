// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/*
int [,] CreateRandomTwoDimArray (int row, int colm, int min, int max)
{
    int [,] newArray = new int [row,colm];
    for (int i = 0; i < row; i++)
        for ( int j = 0; j < colm; j ++)
            newArray[i,j] = new Random().Next(min, max +1);
    
    return newArray;
}

void ShowTwoDimArray (int [,] array)
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

Console.Write("Input numbers of columns ");
int colm  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min number of array ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max number of array ");
int max  = Convert.ToInt32(Console.ReadLine());


int [,] newMatrix = CreateRandomTwoDimArray(row, colm, min, max); 
ShowTwoDimArray(newMatrix);
Console.WriteLine();


int [,] SortTwoDimArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] > array[i, k+1])
                {
                    int temp = array[i, k];
                    array[i,k] = array[i, k+1];
                    array[i,k+1] = temp;
                }
            }
        }
    }
    
    return array;
}
SortTwoDimArray(newMatrix);
ShowTwoDimArray(newMatrix);

*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int [] SumRow (int [,] array, int row)
{
    int sum = 0;
    int k = 0;
    int line = 0;
    int [] sumArray = new int [row];
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum +=array[i,j];
            
        }
        sumArray[k] = sum;
        //Console.Write(sumArray[k] + " ");
        k++;
        sum = 0;
        
    }
    int min = sumArray[0];
    for (k = 0; k < row-1; k++)
    {
        if (min > sumArray[k]) 
        {
            min = sumArray[k];
            line = k+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine("номер строки с наименьшей суммой " + line);

    return sumArray;
}

SumRow(newMatrix, row);
*/


//Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

 //Сделал для любых массивов
 /*
void ShowTwoDimArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int [,] CreateSpiralArray (int m, int n)
{
    int [,] spiralArray = new int [m,n];
    int i = 0;
    int j = 0;
    int count = 0;
    int c = 1;
    int c1 = 0;
    for (i = 0; i<spiralArray.GetLength(0); i++)
    {
    while (j < n-c)
    {
        spiralArray[i,j] = count +1;
        j++;
        count ++;
    }
    while (i < m-c)
    {
        spiralArray[i,j] = count+1;
        i++;
        count++;
    }
    while (j >c1)
    {
        spiralArray[i,j] = count +1;
        j--;
        count++;
    }
    while(i>c1)
    {
        spiralArray[i,j] = count + 1;
        i--;
        count++;
    }
    c++;
    c1++;
    }
    

    return spiralArray;
}

int m = 10;
int n = 15;

ShowTwoDimArray(CreateSpiralArray(m,n));
*/