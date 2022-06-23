/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первoе целое число: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int third = int.Parse(Console.ReadLine());
int max = first;
if (second>max)
{
    max = second;
    Console.WriteLine($"Ответ: {max}");
}
if (third>max)
{
    max = third;
    Console.WriteLine($"Ответ: {max}");
}
if (first == max)
{
    Console.WriteLine($"Ответ: {max}");
}


