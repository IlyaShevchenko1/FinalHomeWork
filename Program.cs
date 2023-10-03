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
/*
SortArray(string[])
{

}
*/

string[]array = new string[5];
CreateArray(array);
PrintArray(array);