Console.Clear();

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите еще одно число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("И еще одно число: ");
int num3 = int.Parse(Console.ReadLine());

int max = 0;

if(num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}


if(max > num3)
{
   Console.WriteLine($"{max} - наибольшее число");
}
else
{
    Console.WriteLine($"{num3} - наибольшее число");
}