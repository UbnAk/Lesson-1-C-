// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int numberA = 0;
int numberB = 0;
int numberC = 0;
Console.WriteLine("Введите три числа: ");
numberA = int.Parse(Console.ReadLine());
numberB = int.Parse(Console.ReadLine());
numberC = int.Parse(Console.ReadLine());
if (numberA>numberB && numberA>numberC)
{
    Console.Write("Максимальное число: ");
    Console.Write(numberA);
}
else if (numberB>numberA && numberB>numberC)
{
    Console.Write("Максимальное число: ");
    Console.Write(numberB);
}
else if (numberC>numberA && numberC>numberB)
{
    Console.Write("Максимальное число: ");
    Console.Write(numberC);
}