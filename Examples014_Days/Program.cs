Console.WriteLine("Введите цифру дня недели");
int x = int.Parse(Console.ReadLine()!);

if (x == 1)
{
    Console.Write("Понедельник -  рабочий день");
}

else if (x == 2)
{
    Console.Write("Вторник - рабочий день");    
}
else if (x == 3)
{
    Console.Write("Среда - рабочий день");
}
else if (x == 4)
{
    Console.Write("Четверг - рабочий день");
}
else if (x == 5)
{
    Console.Write("Пятница - рабочий день");
}
else if (x == 6)
{
    Console.Write("Суббота- выходной");
}
else if (x == 7)
{
    Console.Write("Воскресенье - выходной");
}
if (x < 1 || x > 7)
{
    Console.Write("Вы ввели не корректный день недели");
}
