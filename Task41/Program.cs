/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
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

int MoreZeroArray(int[] tapedArray)
{
    int count = 0;
    for (int i = 0; i < tapedArray.Length; i++)
    {
        if (tapedArray[i] >= 1)
        {
          count++;  
        }
    }
    return count;
}

int[] arrayNumber = CreateArray(10);
PrintArray(arrayNumber);
int result = MoreZeroArray(arrayNumber);
Console.WriteLine($"Кол-во цифр больше нуля: {result}");