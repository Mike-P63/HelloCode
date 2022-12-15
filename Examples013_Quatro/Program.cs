Console.Clear();
Console.WriteLine("введите число 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = int.Parse(Console.ReadLine());
int sq1 = Sq(num1);
int sq2 = Sq(num2);

if (sq1 == num2 || sq2 == num1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Sq (int a)
{
    return a * a;
}
