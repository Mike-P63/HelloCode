﻿Console.Clear();
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);
if (number == 6 || number  == 7)
{
    Console.Write("Под цифрой " + number + " - Выходной день");
}
else
{
    Console.Write("Под цифрой " + number + " - Рабочий день");
}
