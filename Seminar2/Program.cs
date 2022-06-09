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

