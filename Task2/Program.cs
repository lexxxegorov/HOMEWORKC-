int number1 = new int();
int number2 = new int();

Console.Write("Введите число: a = ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: b = ");
number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;


Console.Write("a = ");
Console.WriteLine(number1);
Console.Write("b = ");
Console.WriteLine(number2);

if (number2 > max) max = number2;
{
    Console.Write("Большое число: ");
    Console.WriteLine(max);
}




//int number = new int();
//Console.WriteLine("Введите число");
//number = Convert.ToInt32(Console.ReadLine());

//number = number * number;

//Console.WriteLine(number);