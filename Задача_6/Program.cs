Console.Clear();

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if(num1 % 2 == 0)
{
    Console.WriteLine($"{num1} - четное число");
}
else
{
    Console.WriteLine($"{num1} - нечетное число");
}