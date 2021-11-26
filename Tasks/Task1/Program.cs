Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
int stepen = 2;
if(first == Math.Pow(second,stepen))
{    
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}    