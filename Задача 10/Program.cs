// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10. Вывод второй цифры трехзначного числа");

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = (number / 10) % 10;
    Console.WriteLine("Вторая цифра: {0}", result);
}
else
{
    Console.WriteLine("Введено не трехзначное число.");
}
