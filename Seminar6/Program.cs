
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


