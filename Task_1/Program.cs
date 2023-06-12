//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int number1 = Convert.ToInt32(numberA);
Console.WriteLine("Введите число: ");
string numberB = Console.ReadLine();
int number2 = Convert.ToInt32(numberB);
if (number1 < number2)
{
    Console.WriteLine(numberA + "<" + numberB);
}

if (number2 < number1)
{
    Console.WriteLine(numberB + "<" + numberA);
}

if (number1 == number2)
{
    Console.WriteLine(numberA + "=" + numberB);
}