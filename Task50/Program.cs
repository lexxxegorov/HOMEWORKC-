/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/



int[,] Generate2DArray(int hight, int weight, int delta)
{
    int[,] returnArray = new int[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            returnArray[i, j] = new Random().Next(delta * -1, delta);
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

Console.WriteLine("Введите m : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int SearchElement(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i == m || j == n)
            {
                int number = newArray[m, n];

            }
        }
    }
    return newArray[m, n];
}

int[,] generatedArray = Generate2DArray(4, 4, 10);
Print2DArray(generatedArray);
int result = SearchElement(generatedArray);
Console.WriteLine();
Console.WriteLine($"Есть такое число {result}");
