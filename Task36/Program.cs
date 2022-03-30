/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
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

int[] CreateArray(int length)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(-10, 10);

    }
    return returningArray;
}

int SumOddElement(int[] inputArray)
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += inputArray[i];
        }
    }
    return sum;
}


int[] arrayNumber = CreateArray(5);
PrintArray(arrayNumber);

int sumResult = SumOddElement(arrayNumber);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumResult}");