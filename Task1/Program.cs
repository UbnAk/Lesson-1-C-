// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = 0;
int b = 0;
Console.WriteLine("Введите два числа: ");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}