// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99)
{
int NumberofGigit = GetNumberofDigit(number);  
int GetNumberofDigit(int number)
{
    int NumberofGigit = 0;
    while (number > 999)
    {
        number /= 10;
        NumberofGigit++;
        int thirdnumber = number % 10;
        Console.WriteLine($"Третья цифра {thirdnumber}");
    }
    return NumberofGigit;
}
}
else 
{
    Console.WriteLine ("Нет третьей цифры");
}

if (number > 99 && number < 1000)
{
    int thirdnumber = number % 10;
     Console.WriteLine($"Третья цифра {thirdnumber}");
}
