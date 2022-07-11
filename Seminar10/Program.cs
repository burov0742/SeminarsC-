
/* Программа выдает число сколько слов содержит более 5 букв.
string [] CreateStringArray (int size)
{
    string[] Words = new string [size];

    for (int i =0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        Words[i] = Console.ReadLine(); 
    }

    return Words;
}

void ShowArray (string[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int NumberOfLongWords (string [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i ++)
        if (array[i].Length >= 5)
            count ++;

    return count;
}

Console.Write ("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/

//Написать программу, которая принимает на вход два массива строк и возвращает массив из попарно объединенных исходных элементов.

string[] FirstNumber = {"1","2","3","4"};
string [] SecondNumber = {"1","2","3","4","5","6"};
/*
string[] SumOfStringArray (string [] array1, string [] array2)
{
    int minSize;
   if(array1.Length > array2.Length)
   {
        minSize = array2.Length;
        for (int i = 0; i < minSize; i++)
        {
            array1[i] += array2[i];

        }
        return array1;
   }
        
    else 
    {
        minSize = array1.Length;
        for (int i = 0; i < minSize; i++)
        {
            array2[i] += array1[i];
        }
        return array2;
    }
}


void ShowArray (string[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

ShowArray(SumOfStringArray(FirstNumber,SecondNumber));
*/

//Написать программу, которая считает кол-во слов, начинающихся на букву Y или W.

string [] CreateStringArray (int size)
{
    string[] Words = new string [size];

    for (int i =0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        Words[i] = Console.ReadLine(); 
    }

    return Words;
}

int FindWords (string[] array, char a, char b)
{
    int count = 0;
    
    for(int i=0; i < array.Length; i++)
    {
        if (array[i][0] == a || array[i][0] == b) 
            count ++;
    }
    return count;
}

Console.Write ("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input simbol: ");
char a = Convert.ToChar(Console.ReadLine());

Console.Write ("Input second simbol: ");
char b = Convert.ToChar(Console.ReadLine());

string [] names = CreateStringArray(size);

Console.WriteLine("Amount words is " + FindWords(names, a, b));
