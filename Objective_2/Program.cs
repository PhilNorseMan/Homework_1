//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22

Console.WriteLine("Программа нахождения максимального из трех чисел");

Console.WriteLine("Введите первое число:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число:");
int number_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число:");
int number_3 = int.Parse(Console.ReadLine()!);

int max = number;

if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;

Console.WriteLine("максимальное из введенных чисел это число " + max);