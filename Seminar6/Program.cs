/*
int[] ReverseArray (int[] array)
{
    int temp;
    int j = array.Length - 1;
    int i = 0;

    while (i < j)
    {
        temp = array[i];
        array [i] = array [j];
        array [j] = temp;

        i++;
        j--;
    }
    
    return array;
}

int[] myArray = {2, 4, 6, 8, 10};

myArray = ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool Triangle (int a, int b, int c)
{
    if (a+b > c && a+c > b && b+c > a) return true;
    else return false;
}

Console.Write("Imput lenght a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput lenght b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput lenght c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a,b,c));

*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*
int[] Fibonacci (int n )
{
    int [] newFibonacci = new int[n];
    newFibonacci[0] = 0;
    newFibonacci[1] = 1;
    Console.Write(newFibonacci[0] + " " + newFibonacci[1] + " ");
    for(int i=2; i < n; i++)
    {
        
        newFibonacci[i] = newFibonacci[i-1] + newFibonacci[i-2];
        
        Console.Write(newFibonacci[i] + " ");
    }
    Console.WriteLine();

    return newFibonacci;
}


Console.Write("Imput Fibo numbers:  ");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fibonacci(n));

*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.


string ConvertNum (int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num /=2; 

    }

    return result;
}

Console.WriteLine(ConvertNum(10));