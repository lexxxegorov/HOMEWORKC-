int number1 = new int();
int number2 = new int();
int number3 = new int();

Console.Write("Введите число: a = ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: b = ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: C = ");
number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Большое число: ");
Console.WriteLine(max);