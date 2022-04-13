/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

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

int[,] Sort2DArray(int[,] returnArray)
{
    for (int i = 0; i < returnArray.GetLength(0); i++)
    {
        for (int j = 0; j < returnArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < returnArray.GetLength(1); k++)
            {
                if (returnArray[i, j] < returnArray[i, k])
                {
                    int temp = returnArray[i, j];
                    returnArray[i, j] = returnArray[i, k];
                    returnArray[i, k] = temp;
                }
            }

        }
    }
    return returnArray;
}




int[,] generatedArray = Generate2DArray(5, 5, 10);
Print2DArray(generatedArray);
int[,] sortedArray = Sort2DArray(generatedArray);
System.Console.WriteLine();
Print2DArray(sortedArray);