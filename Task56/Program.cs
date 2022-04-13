/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int[,] Generate2DArray(int hight, int weight, int delta)
{
    int[,] returnArray = new int[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            returnArray[i, j] = new Random().Next(delta);
        }
    }
    return returnArray;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] SumString(int[,] arrayforSumString)
{
    int[] arraySumString = new int[arrayforSumString.GetLength(0)];
    for (int i = 0; i < arrayforSumString.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrayforSumString.GetLength(1); j++)
        {
            sum = sum + arrayforSumString[i, j];
            arraySumString[i] = sum;
        }
        Console.WriteLine($"Сумма строки # {i} = {arraySumString[i]}");
    }
    return arraySumString;
}

int MinSum(int[] arrayMinSum)
{

    int min = arrayMinSum[0];
    int index = 0;

    for (int i = 0; i < arrayMinSum.Length; i++)
    {
        if (arrayMinSum[i] < min)
        {
            min = arrayMinSum[i];
            index = i;
        }
    }
    return index;
}

int[,] generatedArray = Generate2DArray(5, 5, 10);
Print2DArray(generatedArray);
Console.WriteLine();
int[] result = SumString(generatedArray);
Console.WriteLine();
int minResult = MinSum(result);
Console.WriteLine($"Строка с наименьшей суммой элементов #{minResult}");

