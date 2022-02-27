int number = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());


if (number%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}