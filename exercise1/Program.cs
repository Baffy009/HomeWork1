// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.WriteLine("Введите второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);
if (num1 > num2)
{
    Console.Write("max=");
    Console.WriteLine(num1);
    Console.Write("min=");
    Console.WriteLine(num2);
}
else if (num1 < num2)
{
    Console.Write("max=");
    Console.WriteLine(num2);
    Console.Write("min=");
    Console.WriteLine(num1);
}