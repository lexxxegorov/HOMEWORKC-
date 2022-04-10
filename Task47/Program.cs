/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] Generate2DArray(int hight, int weight)
{
    double[,] returnArray = new double[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            returnArray[i,j] = new Random().NextDouble()* new Random().Next(-100,100);
        }
    }
    return returnArray;
}

void Print2DArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите m ");
int hight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n ");
int weight = Convert.ToInt32(Console.ReadLine());

double[,] generatedArray = Generate2DArray(hight,weight);
Print2DArray(generatedArray);