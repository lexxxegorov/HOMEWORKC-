/*Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] AverageSumColum(int[,] arrayForAverage)
{
    double[] arrayAverrage = new double[arrayForAverage.GetLength(1)];
    for (int j = 0; j < arrayForAverage.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrayForAverage.GetLength(0); i++)
        {
            sum = sum + arrayForAverage[i, j];
            arrayAverrage[j] = sum/arrayForAverage.GetLength(0);
        }
        Console.Write($"{arrayAverrage[j]}\t");
    }
    return arrayAverrage;
}

int[,] generatedArray = Generate2DArray(5, 5, 10);
Print2DArray(generatedArray);
Console.WriteLine();
double[] result = AverageSumColum(generatedArray);
Console.WriteLine();