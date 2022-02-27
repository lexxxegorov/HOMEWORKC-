int number1 = new int();
int number2 = new int();

Console.Write("Введите число: a = ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: b = ");
number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;


if (number2 > max) max = number2; min = number1;

Console.Write("Большое число: ");
Console.WriteLine(max);
Console.Write("Меньшее число: ");
Console.WriteLine(min);





//int number = new int();
//Console.WriteLine("Введите число");
//number = Convert.ToInt32(Console.ReadLine());

//number = number * number;

//Console.WriteLine(number);