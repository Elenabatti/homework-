//Напишите программу, которая на вход принимает пя
//тизначное число и проверяет является ли оно полиндромом.
Console.Clear();
void Palindrom()
{
    Console.Write("Введите пятизначное число, ");
    int i = int.Parse(Console.ReadLine());

    if (i>0 && i<100000)
    {
        if (i /10000 == i % 10 && i/1000%10 == i/10%10)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }    
else
{
  Console.Write("Надо вводить только положительное пятизначные числа");
}
    }
    try
   {
       Palindrom();
    }
   catch
    {
       Console.Write("Надо вводить только числа!");
    }
    
