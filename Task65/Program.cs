/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7"
*/

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void PrintNumber(int numN, int printNumber)
{
    Console.WriteLine($"-> {printNumber}");
    if (printNumber > numN)
    {
        PrintNumber(numN, printNumber - 1);
    }

}

PrintNumber(numM, numN);