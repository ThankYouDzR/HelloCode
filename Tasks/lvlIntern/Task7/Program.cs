// Показать числа от -N до N

Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
int result = -N;
while(result<=N)
{
    Console.Write(result + " ");
    result++;
}