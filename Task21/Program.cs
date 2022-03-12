// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты A:  ");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B:  ");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zB = Convert.ToInt32(Console.ReadLine());


double dlin = new int();

dlin = Math.Pow(((xB - xA)*(xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA)), 0.5);

Console.WriteLine($"Расстояние между точками равно: {Math.Round(dlin, 2)}");