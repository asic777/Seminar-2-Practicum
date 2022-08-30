// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15. Проверка на выходной день недели");

Console.Write("Введите число от 1 до 7: ");
int numberDay = int.Parse(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("Выходной? -> да");
}
else if (numberDay >= 1 && numberDay <= 5)
{
    Console.WriteLine("Выходной? -> нет");
} else {
    Console.WriteLine("Некорректный ввод. Вводите число от 1 до 7.");
}