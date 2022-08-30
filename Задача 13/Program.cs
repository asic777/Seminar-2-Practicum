// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задача 13. Вывод третьей цифры числа");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    Console.WriteLine("Третья цифра: {0}", number % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}