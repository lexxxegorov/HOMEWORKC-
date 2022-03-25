// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Число А: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B: ");
double numB = Convert.ToInt32(Console.ReadLine());
double numDegree = 1;

if (numA > 0 && numB > 0)
{
    numDegree = Math.Pow(numA, numB);
}

Console.WriteLine($"Число {numA} в степени {numB} = {numDegree}");
