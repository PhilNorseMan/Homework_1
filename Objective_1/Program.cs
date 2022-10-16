// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

//Если выдавать большее и меньшее, как в задании, то:

Console.WriteLine("Программа сравнения двух чисел");
Console.WriteLine("Введите первое число:");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число:");

int number_2 = int.Parse(Console.ReadLine()!);

if (number > number_2)
{
    Console.WriteLine("число " + number + " больше, чем " + number_2);
}
else
{
    Console.WriteLine("число " + number_2 + " больше, чем " + number);
}

//Если как в примере, только max=, то:

//Console.WriteLine("Программа сравнения двух чисел");
//Console.WriteLine("Введите первое число:");

//int number = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Введите второе число:");

//int number_2 = int.Parse(Console.ReadLine()!);

//if (number > number_2)
//{
//    Console.WriteLine("max = " + number);
//}
//else
//{
//    Console.WriteLine("max = " + number_2);
//}