/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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
        returningArray[i] = new Random().Next(1, 10);
    }
    return returningArray;
}

int MinElement(int[] minArray)
{

    int min = minArray[0];

    for (int i = 0; i < minArray.Length; i++)
    {
        if (minArray[i] < min)
        {
            min = minArray[i];
        }

    }
    return min;
}

int MaxElement(int[] maxArray)
{
    int max = maxArray[0];
    for (int i = 0; i < maxArray.Length; i++)
    {
        if (maxArray[i] > max)
        {
            max = maxArray[i];
        }
    }
    return max;
}

int[] arrayNumber = CreateArray(5);
PrintArray(arrayNumber);

int minResult = MinElement(arrayNumber);
int maxResult = MaxElement(arrayNumber);

Console.WriteLine($" {maxResult} - {minResult} = {maxResult - minResult}");
