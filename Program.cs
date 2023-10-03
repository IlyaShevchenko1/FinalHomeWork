void  CreateArray(string[]array)
{
    Console.WriteLine("Please input 5 string elements of array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Please input {i + 1}  element of the array: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
}

void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
}

int LengthArray(string[]array)
{
    int  finalArrayLenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            finalArrayLenght++;
        }     
    }
    return finalArrayLenght;
}

void  SortArray(string[]firstArray, string[]secondArray)
{
    for (int i = 0, j = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length < 4)
        {
            secondArray[j] = firstArray[i];
            j++;
        }   
    }
    Console.WriteLine();
}


string[]array = new string[5];
CreateArray(array);
Console.WriteLine("Source array is:");
PrintArray(array);
string[]finalArray = new string[LengthArray(array)];
SortArray(array, finalArray);
Console.WriteLine("Final array is:");
PrintArray(finalArray);