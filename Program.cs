/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/


void  CreateArray(string[]array)  // Функция для ввода элементов массива пользователем
{
    Console.WriteLine("Please input 5 string elements of array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Please input {i + 1}  element of the array: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
}

void PrintArray(string[]array)   // Функция для вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
}

int LengthArray(string[]array)   // Функция для расчета длины нового массива, исходя из условий задачи
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

void  SortArray(string[]firstArray, string[]secondArray) // Функция для выборки нужных эл-ов по условию задачи
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

