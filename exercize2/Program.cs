// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите  первое число: ");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.WriteLine("Введите  второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

Console.WriteLine("Введите  второе число: ");
string input3 = Console.ReadLine();
int num3 = int.Parse(input3);
int max = num1;
if ( num1> max) max=num1;
if ( num2> max) max=num2;
if ( num3> max) max=num3;
Console.Write("max= ");
Console.WriteLine(max);