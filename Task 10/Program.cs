// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 99 || number > 1000)
{
    Console.WriteLine("Число не трехзначное, повторите ввод");
}
else
{
int result = ShowSecondFig (number);
int ShowSecondFig (int number)
{
    int num2 = number/ 10;
    int result = num2 % 10;
    return result;
}
Console.WriteLine("вторая цифра " + result);
}

