// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Сначала создаем метод

/*

int FindQuard(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y > 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

// Далее запрашиваем переменные от пользователя
int x, y;

Console.WriteLine("Введите координату X: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
y = Convert.ToInt32(Console.ReadLine());

int result = FindQuard(x,y);

if (result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine($"Точка расположена в {result} четверти");

*/

/*
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


void Quard(int x)
{
    if (0 < x && x < 5) 
        if (x == 1) Console.WriteLine("Допустимые значения положительные X и Y");
        if (x == 2) Console.WriteLine("Допустимые значения отрицательные X и положительные Y");
        if (x == 3) Console.WriteLine("Допустимые значения отрицательные X и Y");
        if (x == 4) Console.WriteLine("Допустимые значения положительные X и отрицательные Y");
   
    else  Console.WriteLine("Введены недопустимые значения");
}

int x;

Console.WriteLine("Введите номер четверти: ");
x = Convert.ToInt32(Console.ReadLine());

Quard(x);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N включительно.


/*
double FindLenght (double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB - yA),2)); // - Math.Pow (x,y) - функция возведения в степень, где Х возводимое число, а Y - степень.
    
}

*/