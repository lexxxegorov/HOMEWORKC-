// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели:  ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day < 6)
{
    Console.WriteLine("День не выходной");
}
else 
{
    Console.WriteLine("Выходной");   
}
