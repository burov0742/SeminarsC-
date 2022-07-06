// Сгенерировать двумерный массив задваемый размер от пользователя случайными числами
/*
int [,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a, b];

    for (int i = 0; i < a; i++) // индекс строк
    {
        for (int j = 0; j < b; j++) // индекс столбцов
        {
            newMatrix[i,j] = new Random().Next(min, max+1);
            Console.Write(newMatrix[i,j] + " ");
        }

        Console.WriteLine();
    }

    return newMatrix;
}

int [,] array = CreateRandomTwoDemArray(4,5,1,9);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int [,] CreateRandomTwoDemArray (int m, int n)
{
    int [,] newMatrix = new int [m, n];

    for (int i = 0; i < m; i++) // индекс строк
    {
        for (int j = 0; j < n; j++) // индекс столбцов
        {
            newMatrix[i,j] = i + j;
            Console.Write(newMatrix[i,j] + " ");
        }

        Console.WriteLine();
    }

    return newMatrix;
}

int [,] array = CreateRandomTwoDemArray(4,5);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int [,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a, b];

    for (int i = 0; i < a; i++) // индекс строк
    {
        for (int j = 0; j < b; j++) // индекс столбцов
        {
            newMatrix[i,j] = new Random().Next(min, max+1);
            Console.Write(newMatrix[i,j] + " ");
        }

        Console.WriteLine();
    }

    return newMatrix;
}

int [,] FindEvenIndexAndChangeNum (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            if (i%2 == 0 && j%2 == 0) array[i,j] *= array[i,j];
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();

    }

    return array;
}

int [,] newArray = CreateRandomTwoDemArray(5,5,1,9);
Console.WriteLine();

FindEvenIndexAndChangeNum (newArray);
*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int [,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a, b];

    for (int i = 0; i < a; i++) // индекс строк
    {
        for (int j = 0; j < b; j++) // индекс столбцов
        {
            newMatrix[i,j] = new Random().Next(min, max+1);
            Console.Write(newMatrix[i,j] + " ");
        }

        Console.WriteLine();
    }

    return newMatrix;
}
int [,] newArray = CreateRandomTwoDemArray(5,5,1,3);

int FindSumGeneralAxe (int [,] array)
{
    int sum = 0;
    for (int i =0; i < array.GetLength(0); i++) // при наличии в цикле всего одного действия можно не писать фигурные скобки
        for (int j = 0; j < array.GetLength(1); j ++)
            if (i == j) sum += array[i,j];

    return sum;

} 

Console.WriteLine("Sum numbers of general axe is " + FindSumGeneralAxe (newArray));
*/