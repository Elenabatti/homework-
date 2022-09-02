// Написать программу,которая принимает на вход число и выдаёт таблицу кубов от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;
while(count <= n)
{
    Console.WriteLine(Math.Pow(count, 3));
    count ++;
}
