Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine()!);
int numberC = -numberN;
while (numberC<=numberN)
{
    Console.Write(numberC+" ");
    numberC++;
}