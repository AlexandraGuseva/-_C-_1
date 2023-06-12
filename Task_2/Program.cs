// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int number1 = Convert.ToInt32(numberA);
Console.WriteLine("Введите число: ");
string numberB = Console.ReadLine();
int number2 = Convert.ToInt32(numberB);
Console.WriteLine("Введите число: ");
string numberC = Console.ReadLine();
int number3 = Convert.ToInt32(numberC);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Максимальное значение имеет число: " + max);