// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int reverseNum = GetreverseNum(number);
int GetreverseNum(int number)
{
    int reverseNum = 0;
    while (number != 0)
    {
    int remainder = number%10;
    reverseNum = reverseNum * 10 + remainder;
    number = number/10;
    }
    Console.WriteLine (reverseNum);
    return reverseNum;
}
if (number == reverseNum)
{
    Console.WriteLine("Palidrom");
}
else
{
    Console.WriteLine("Not Palidrom");
}