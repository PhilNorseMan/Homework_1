//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Программа вывода четных чисел от 1 до заданного числа");

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int temp = 1;

while (temp <= number)
{
    Console.Write(temp + " ");
    temp++;
}

if (number < 0)
{
    Console.WriteLine("Невозможно отобразить числа от 1 до " + number + ". Выполняется отображение от " + number + " до 1.");
    while (temp >= number)
    {
        Console.Write(number + " ");
        number++;
    }
}

