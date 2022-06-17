// Задача №1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* - Решение без цикла
double FindRank(int num, int rank)
{
      
    double result;
    return  result = Math.Pow(num, rank);

}

Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput rank: ");
int rank = Convert.ToInt32(Console.ReadLine());

if (num < 0 ) num *= -1;
if (rank < 0) rank *= -1;

double result = FindRank(num, rank);

Console.WriteLine($"{num} in rank {rank} is {result}");

*/

/* Задача №1 : с использованием цикла

int FindRank (int A, int B)
{   
    int rank = A;
    int count = 1;
    while(count < B)
    {
        rank *= A;
        count ++;
    }

    return rank;
}

Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput rank: ");
int rank = Convert.ToInt32(Console.ReadLine());

if (num < 0 ) num *= -1;
if (rank < 0) rank *= -1;

double result = FindRank(num, rank);

Console.WriteLine($"{num} in rank {rank} is {result}");
*/


// Задача №2: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]



int size = 8;
int [] RandomNumbers = new int [size];

for (int i = 0; i < size; i ++) 
{
    RandomNumbers[i] = new Random().Next(0,100); // Нет уточненния откуда берем массив и какой диапозоон, поэтому используем случайные значния от 0 до 100
    
}

for (int i = 0; i < size; i++)
{
    Console.Write( RandomNumbers[i] + ", "); 
    
}
