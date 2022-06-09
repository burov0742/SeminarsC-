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
