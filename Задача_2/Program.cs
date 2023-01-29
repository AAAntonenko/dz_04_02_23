Console.Clear();

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите еще одно число: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1}>{num2}");
}
else
{
    Console.WriteLine($"{num2}>{num1}");
}