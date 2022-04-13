/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/
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

int [,] MultiplyArraies(int[,] firstArray, int[,] secondArray)
{
    int[,] multiArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(0); k++)
            {
                multiArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return multiArray;
}

int [,] generation1 = Generate2DArray (3, 3, 10);
int [,] generation2 = Generate2DArray (3, 3, 10);
Print2DArray(generation1);
Console.WriteLine();
Print2DArray(generation2);
Console.WriteLine();
int[,] resultArray = MultiplyArraies (generation1, generation2);
Print2DArray(resultArray);