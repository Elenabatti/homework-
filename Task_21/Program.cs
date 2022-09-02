//Напишите программу, которая принимает на вход координаты 2х точек
//и находит расстояние между ними в 3D пространстве
Console.Clear();
Console.WriteLine("Input A(x, y)");

Console.Write("x: ");
int x1  = int.Parse(Console.ReadLine());
Console.Write("y: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("x: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Input B(x, y");
Console.Write("y: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("x: ");
int x3  = int.Parse(Console.ReadLine());
Console.Write("y: ");
int y3 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - y1, 2) + (Math.Pow(x2 - y2, 2) + (Math.Pow(x3 =y2,2)))));
