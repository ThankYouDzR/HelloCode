// Показать четные числа от 1 до N

Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;
while (result <= N)
{
    if (result%2==0)
    {
        Console.Write(result);
    }
    else
    {
        Console.Write(" ");
    }
    result++;
}
