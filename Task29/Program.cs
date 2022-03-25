// Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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


int[] createRandomArray(int length)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(-100, 100);
    }
    return returningArray;
}


int[] arrayNumberOne = createRandomArray(5);
int[] arrayNumberTwo = createRandomArray(3);

PrintArray(arrayNumberOne);
PrintArray(arrayNumberTwo);