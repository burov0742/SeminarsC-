//Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

/*
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


int FindSumVawelWords (string [] array)
{
    char a = 'a';
    char e = 'e';
    char i = 'i';
    char o = 'o';
    char u = 'u';
    char y = 'y';
    int count = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k][0] == a || array[k][0] == e ||array[k][0] == i ||
        array[k][0] == o ||array[k][0] == u || array[k][0] == y)
            count++;
    }
    return count;
}

Console.Write ("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] myWords = CreateStringArray(size);

Console.WriteLine("Amount of words with first vawe is " + FindSumVawelWords(myWords));

*/

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
/*
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

string[] CreateJoinArray (string[] array, int size)
{
    string[] joinArray = new string [array.Length];
    if(size%2 == 0)
    {
        
        for (int i = 0; i < joinArray.Length-1; i+=2)
            joinArray[i] = array[i] + array[i+1];
    }
    else Console.WriteLine("Input even number of words!");
    
    return joinArray;
}


Console.Write ("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] myWords = CreateStringArray(size);

ShowArray(CreateJoinArray(myWords, size));

*/