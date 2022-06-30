// Вывод рисунка

/*
void PrintArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); // принудительный перевод на новую строку после прохождения всей строки
    }
}

void FiilArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,10); // При использовании метода Next() интервыл указывается невключая верхнее значение [0, 10)
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix = new int [3, 4];

PrintArray(matrix);
Console.WriteLine();
FiilArray(matrix);
*/

// Закраска рисунка
/*

int [,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 1 ,1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0},
    {0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
};

void PrintPic (int [,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            
            if (image[i, j] == 0) Console.Write (" ");
            else Console.Write("+");
        }
    Console.WriteLine(); // принудительный перевод на новую строку после прохождения всей строки
    }
}

PrintPic(pic);
Console.WriteLine();

void FillImage (int row, int colm)
{
    if (pic[row, colm] == 0)
    {
        pic[row, colm] = 1;
        FillImage (row - 1, colm);
        FillImage (row, colm - 1);
        FillImage (row + 1, colm);
        FillImage (row, colm +1);

    }
}


FillImage(5, 5);
PrintPic(pic);
Console.WriteLine();

*/

//Использование рекурсии при вычислении факториала

/*

double Factorial (int n) // INT не может вместить большие цифры, поэтому необходимо использовтаь DOUBLE
{   
    // 1! = 1
    // 0! = 1
    if (n == 1 ) return 1;
    else return n * Factorial(n-1);

}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

*/

// использование рекурсии при вычислении цифр Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}