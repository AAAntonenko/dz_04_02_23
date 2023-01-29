Console.Clear();

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = -num1;

while(num1+1 > num2)
{
    if(num2 % 2 == 0)
    {
        Console.Write($"{num2} ");
    }
num2++;    
}