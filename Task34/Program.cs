// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] CreateArray(int length)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(99, 999);
    }
    return returningArray;
}

int EvenElementArray(int [] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]%2 == 0)
        {
          count++;  
        }
    }
    return count;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    System.Console.WriteLine();
}

int[] arrayNumber = CreateArray(5);
PrintArray(arrayNumber);

int result = EvenElementArray(arrayNumber);
Console.WriteLine(result);
