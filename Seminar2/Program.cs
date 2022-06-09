/*
int FindMaxPart(int num)
{
    int des, ed;

    if (num >= 10 && num <=99)
    {
        des = num / 10;
        ed = num % 10;

        if (des>ed)
        {
            return des;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}

Console.Write ("Imput two-digitel number: ");
int a = Convert.ToInt32 (Console.ReadLine());

int result = FindMaxPart(a);

if (result == -1)
{
    Console.WriteLine ("Your number is not two-digital");

}
else
{
    Console.WriteLine($"The biggest number of {a} is {result}");
}

*/

/*

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int TwoDigtalNumber()
{
    int num1, num3;
    int num = new Random().Next (100,1000);
    Console.WriteLine (num);
    
    num1 = num / 100;
    num3 = num % 10;

    int result = num1*10 + num3;
    return result;
}

Console.WriteLine (TwoDigtalNumber());

*/

/*
// Задача: делиться ли второе число на первое без остатка. Если нет, то вывести остаток
string IsAliquot(int num1, int num2)
{
    if (num2 % num1 == 0) //return "True"; При одном действии можно писать в строку
    {
        return "True";
    }
    else // return ("False, rest num is " + (num2 % num1)); При одном действии можно писать в строку
    {
        return ("False, rest num is " + (num2 % num1));
    }
}

int a, b;

Console.Write("Imput number a:");
a = Convert.ToInt32 (Console.ReadLine());

Console.Write("Imput number b:");
b = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (IsAliquot(a,b));


/*

//Задача: делиться ли число на 23 и на 7 одновременно без остатка. 


bool IsAliquot2 (int num) // переменная bool - определяет значения true или fals
{
    // if (num % 23 == 0 && num % 7 == 0) return true;
    // else return false;

    return (num % 23 == 0 && num % 7 == 0);
}

if (0IsAliquot2 (10)) Console.WriteLine("число кратно");
else Console.WriteLine("число yt кратно");
*/