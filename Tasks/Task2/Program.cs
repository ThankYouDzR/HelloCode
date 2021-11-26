Console.WriteLine("Введите первое число");
string firstString = Console.ReadLine();
int first = Convert.ToInt32(firstString);
Console.WriteLine("Введите второе число");
string secondString = Console.ReadLine();
int second = Convert.ToInt32(secondString);
int stepen = 2;
if(first == Math.Pow(second,stepen))
{    
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}    