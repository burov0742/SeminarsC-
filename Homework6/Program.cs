//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int Numbers (int size)
{
    
    int count = 1;
    int amount = 0;
    while (count <= size)
    {
        Console.Write ("Imput number ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            amount += 1;
        }
        
        count ++;
    }
    ;
    return amount;
}

Console.Write("Positive numbers is " + Numbers(size));
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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


int [] CopyArray (int [] array)
{
    int [] CopyArray = new int [size];
    for( int i =0; i < array.Length; i++)
    {
        CopyArray[i] = array[i];
        Console.Write(CopyArray[i] + ", ");
    }

    return  CopyArray;
}

int [] finalArray = CopyArray(CreatorRandomArray(size));

*/