//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число:");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);
if (num1 % 2==1)
{
    Console.WriteLine("Нет");       
}
else
{
    Console.WriteLine("Да");
}