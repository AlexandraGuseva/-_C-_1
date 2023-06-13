// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int number1 = Convert.ToInt32(number);

if (number1 % 2 == 0)
{
    Console.WriteLine("Число " + number1 + " четное");
}
else
{
    Console.WriteLine("Число " + number1 + " нечетное");
}
